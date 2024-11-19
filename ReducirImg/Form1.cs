namespace ReducirImg
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths = new List<string>();
        private string outputFolder = "";
        public Form1()
        {
            InitializeComponent();
            InitializeResolutionComboBox();
        }

        private void InitializeResolutionComboBox()
        {
            // Agregar resoluciones predefinidas al ComboBox
            cmbResolutions.Items.Add("800x600");
            cmbResolutions.Items.Add("1024x768");
            cmbResolutions.Items.Add("1080x1080");
            cmbResolutions.Items.Add("1280x720");
            cmbResolutions.Items.Add("1500x500");
            cmbResolutions.Items.Add("1920x1080");
            cmbResolutions.Items.Add("2560x1440");
            cmbResolutions.SelectedIndex = 0; // Seleccionar por defecto 800x600
        }




        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePaths.AddRange(ofd.FileNames);
                  //  lstImages.Items.Clear();
                   // lstImages.Items.AddRange(imagePaths.ToArray());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void cmbResolutions_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnResizeImages_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abrir el diálogo para seleccionar la carpeta de destino
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputFolder = folderDialog.SelectedPath; 

                    
                    string selectedResolution = cmbResolutions.SelectedItem.ToString();
                    var dimensions = selectedResolution.Split('x');
                    int width = int.Parse(dimensions[0]);
                    int height = int.Parse(dimensions[1]);
                    .
                    
                    long quality = trackBarQuality.Value;

                    
                    foreach (var imagePath in imagePaths)
                    {
                        string filename = Path.GetFileName(imagePath);  
                        string newFilePath = Path.Combine(outputFolder, filename); 

                        // Redimensionar y comprimir la imagen
                        ImageResizer.ResizeImage(imagePath, newFilePath, width, height, quality);
                    }

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("Las imágenes se han redimensionado y comprimido correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se seleccionó una carpeta de destino. La operación se ha cancelado.", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBarQuality_Scroll(object sender, EventArgs e)
        {
            int qualityValue = trackBarQuality.Value;
            lblQuality.Text = $"Calidad: {qualityValue}%"; // Mostrar el valor en el Label
        }
    }
}
