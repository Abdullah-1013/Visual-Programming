using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DataBase_Connection
{
    public partial class Form1 : Form
    {
        private string selectedImagePath;
        private int currentIndex = 0;
        private DataTable dt = new DataTable();
        private SqlConnection con;

        public Form1()
        {
            con = new SqlConnection("Data Source=DESKTOP-OC2HDE7;Initial Catalog=\"DataBase Connection\";Integrated Security=True;TrustServerCertificate=True");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (ctrl.Text.Length == 0)
                    {
                        isEmpty = true;
                        break;
                    }
                }
            }

            if (isEmpty)
            {
                MessageBox.Show("Field cannot be empty");
            }
            else
            {
                // Check if the ID, Email, and Serial Number already exist
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM StudentInfo WHERE Email = @Email OR SerialNumber = @SerialNumber";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@Email", textBox3.Text);
                checkCmd.Parameters.AddWithValue("@SerialNumber", textBox1.Text);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Email or Serial Number already exists.");
                    con.Close();
                    return;
                }

                // Image processing (Grayscale) before storing the image URL
                string imageURL = ProcessImage(selectedImagePath);

                // Set the ImageURL text field with the grayscale image path
                textBox6.Text = imageURL;  // Automatically store in the ImageURL text field

                // Insert the new data
                string query = "INSERT INTO StudentInfo(Name, Email, Password, FatherName, ImageURL, SerialNumber) " +
                               "VALUES(@Name, @Email, @Password, @FatherName, @ImageURL, @SerialNumber)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", textBox4.Text);
                cmd.Parameters.AddWithValue("@Email", textBox3.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                cmd.Parameters.AddWithValue("@FatherName", textBox5.Text);
                cmd.Parameters.AddWithValue("@ImageURL", imageURL);
                cmd.Parameters.AddWithValue("@SerialNumber", textBox1.Text);

                int insertCount = cmd.ExecuteNonQuery();
                if (insertCount > 0)
                {
                    MessageBox.Show("Data Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }
                con.Close();
            }
        }
        private string ProcessImage(string imagePath)
        {
            try
            {
                // Load the image
                using (Image image = Image.FromFile(imagePath))
                {
                    // Convert to grayscale
                    Bitmap grayscaleBitmap = new Bitmap(image);
                    for (int y = 0; y < grayscaleBitmap.Height; y++)
                    {
                        for (int x = 0; x < grayscaleBitmap.Width; x++)
                        {
                            Color pixelColor = grayscaleBitmap.GetPixel(x, y);
                            int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                            Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                            grayscaleBitmap.SetPixel(x, y, grayColor);
                        }
                    }

                    // Generate a unique file name for the grayscaled image
                    string fileName = "grayscale_image_" + Guid.NewGuid().ToString() + ".jpg";  // Unique file name using GUID
                    string grayImagePath = Path.Combine("C:\\Users\\ab\\Pictures", fileName);  // Save to the specified path

                    // Save the grayscaled image to the specified path
                    grayscaleBitmap.Save(grayImagePath);

                    // Return the path of the grayscale image
                    return grayImagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing image: " + ex.Message);
                return string.Empty;
            }
        }

        /*

        private string ProcessImage(string imagePath)
        {
            try
            {
                // Load the image
                using (Image image = Image.FromFile(imagePath))
                {
                    // Convert to grayscale
                    Bitmap grayscaleBitmap = new Bitmap(image);
                    for (int y = 0; y < grayscaleBitmap.Height; y++)
                    {
                        for (int x = 0; x < grayscaleBitmap.Width; x++)
                        {
                            Color pixelColor = grayscaleBitmap.GetPixel(x, y);
                            int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                            Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                            grayscaleBitmap.SetPixel(x, y, grayColor);
                        }
                    }

                    // Save the grayscaled image to a new file
                    string grayImagePath = "C:\\Users\\ab\\Pictures";  // Modify with your desired path
                    grayscaleBitmap.Save(grayImagePath);

                    // Return the path of the grayscale image
                    return grayImagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing image: " + ex.Message);
                return string.Empty;
            }
            */

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM StudentInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE StudentInfo SET Name=@Name, SerialNumber=@SerialNumber, ImageURL=@ImageURL, FatherName=@FatherName, Email=@Email, Password=@Password WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Email", textBox3.Text);
            cmd.Parameters.AddWithValue("@Password", textBox4.Text);
            cmd.Parameters.AddWithValue("@ID", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@FatherName", textBox5.Text);
            cmd.Parameters.AddWithValue("@ImageURL", textBox6.Text);  // ImageURL from the text field
            cmd.Parameters.AddWithValue("@SerialNumber", textBox1.Text);

            int count = cmd.ExecuteNonQuery();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Updated Successfully");
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM StudentInfo WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", numericUpDown1.Value);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Deleted Successfully");
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            dt.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM StudentInfo", con);
            sda.Fill(dt);
            con.Close();

            bool hasRecords = dt.Rows.Count > 0;

            if (hasRecords)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == currentIndex)
                    {
                        numericUpDown1.Value = Convert.ToDecimal(dt.Rows[i]["ID"]);
                        textBox2.Text = dt.Rows[i]["Name"].ToString();
                        textBox3.Text = dt.Rows[i]["Email"].ToString();
                        textBox4.Text = dt.Rows[i]["Password"].ToString();

                        currentIndex = (i + 1) % dt.Rows.Count;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No records found");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                MessageBox.Show("Image selected: " + selectedImagePath);
            }
        }
    }
}
