using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimCoreyFullStackChallengeWinforms
{
    public partial class FrmEmployeeDirectory : Form
    {
        public FrmEmployeeDirectory()
        {
            InitializeComponent();
        }

        private async Task UpdateEmployeeList()
        {
            try
            {
                const string apiLocation = "https://localhost:7025";
                using HttpClient client = new();
                var response = await client.GetFromJsonAsync<Employee[]>(apiLocation);
                if (response is null)
                {
                    MessageBox.Show("An error occured while trying to fetch the employees.");
                }
                else
                {
                    lbxEmployees.Items.Clear();
                    lbxEmployees.Items.AddRange(response);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("An error occured while trying to fetch the employees.");
            }
            
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await UpdateEmployeeList();
        }

        private async void FrmEmployeeDirectory_Load(object sender, EventArgs e)
        {
            await UpdateEmployeeList();
        }
    }
}
