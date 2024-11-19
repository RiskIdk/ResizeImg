using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;


namespace ReducirImg
{
    public static class ImageResizer
    {

        public static void ResizeImage(string inputImagePath,string outputImagePath, int width, int height, long quality)
        {
            // Abrir la imagen original
            using (Image originalImage = Image.FromFile(inputImagePath))
            {
                // Redimensionar la imagen
                // Cargar la imagen original
                // Crear una nueva imagen redimensionada
                using (Bitmap resizedImage = new Bitmap(originalImage, new Size(width, height)))
                {
                    // Crear un códec JPEG
                    ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");

                    // Parámetros de compresión
                    EncoderParameters encoderParameters = new EncoderParameters(1);
                    encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);

                    // Guardar la imagen redimensionada con la compresión especificada
                    resizedImage.Save(outputImagePath, jpegCodec, encoderParameters);
                }
            }
            }
        

            private static ImageCodecInfo GetEncoderInfo(string mimeType)
            {
                // Obtener los códecs de imágenes instalados
                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

                // Buscar el códec correspondiente al tipo de imagen
                foreach (ImageCodecInfo codec in codecs)
                {
                    if (codec.MimeType == mimeType)
                        return codec;
                }

                return null;
            }
        }
    }

