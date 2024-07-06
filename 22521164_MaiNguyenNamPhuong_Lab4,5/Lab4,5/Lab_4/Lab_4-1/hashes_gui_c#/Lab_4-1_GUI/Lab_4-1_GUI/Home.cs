using System.Runtime.InteropServices;

namespace Lab_4_1_GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        string input_option;
        string input_data;
        string output_filename;
        string algo;

        int shakeLength = 0;
        [DllImport("hashes.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "hashes")]
        public static extern void hashes(string algo, string input_option, string input_data, string output_filename, int shakeLength);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại cho phép người dùng chọn giữa mở hoặc tạo file


            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị đường dẫn file được chọn trong txbInput
                txbInput.Text = openFileDialog.FileName;
                input_data = openFileDialog.FileName;
            }
            /*else if (result == DialogResult.No) // Người dùng chọn tạo file mới
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Tạo file mới tại đường dẫn đã chọn
                    File.Create(saveFileDialog.FileName).Close();

                    // Hiển thị đường dẫn file mới tạo trong txbInput
                    txbInput.Text = saveFileDialog.FileName;
                }
            }*/
        }

        private void btnOpenOutput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị đường dẫn file được chọn trong txbInput
                txbOutput.Text = openFileDialog.FileName;
                output_filename = openFileDialog.FileName;
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            algo = comboBox1.Text;
            input_option = "file";
            if (algo == "SHAKE128" || algo == "SHAKE256")
            {
                shakeLength = int.Parse(txbOutLeng.Text);
            }
            try
            {
                // Gọi hàm hashes
                hashes(algo, input_option, input_data, output_filename, shakeLength);

                // Hiển thị thông báo thành công
                MessageBox.Show("Hashing operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Hashing operation failed. Please check your inputs and try again.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHash_2_Click(object sender, EventArgs e)
        {
            string algo = cbType_2.Text;
            string input_option = "screen";
            string input_data = txbInput_2.Text;
            string output_filename = System.IO.Path.GetTempFileName(); // Tạo file tạm thời
            int shakeLength = 0;

            if (algo == "SHAKE128" || algo == "SHAKE256")
            {
                shakeLength = int.Parse(txbOutLeng_2.Text);
            }

            try
            {
                // Gọi hàm hashes
                hashes(algo, input_option, input_data, output_filename, shakeLength);

                // Hiển thị thông báo thành công
                MessageBox.Show("Hashing operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đợi một chút để đảm bảo file đã được ghi
                System.Threading.Thread.Sleep(100);

                // Kiểm tra xem file có tồn tại không
                if (System.IO.File.Exists(output_filename))
                {
                    // Đọc nội dung từ file temp.txt và hiển thị trong txbOutput_2
                    string outputContent = System.IO.File.ReadAllText(output_filename);
                    txbOutput_2.Text = outputContent;
                }
                else
                {
                    MessageBox.Show("Temporary output file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Hashing operation failed. Please check your inputs and try again.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Xóa file tạm thời nếu không cần nữa
                if (System.IO.File.Exists(output_filename))
                {
                    System.IO.File.Delete(output_filename);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txbOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
