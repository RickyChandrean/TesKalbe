using System;
using System.Data;

namespace TesKalbe
{
    public partial class study : System.Web.UI.Page
    {
        private void tampilData()
        {
            string display = "<table ID='table' class='table table-striped table-bordered' style='width:100%'>";
            display += "<thead>";
            display += "<tr>";
            display += "<th>ID</th>";
            display += "<th>Study Id</th>";
            display += "<th>Version Id</th>";
            display += "<th>Protocol Title</th>";
            display += "<th>Protocol Code</th>";
            display += "<th>Molecules ID</th>";
            display += "<th>StudyStatus ID</th>";
            display += "<th>Is Active</th>";
            display += "<th>Is Deleted</th>";
            display += "<th>Created By</th>";
            display += "<th>Created Date</th>";
            display += "<th>Update By</th>";
            display += "<th>Update Date</th>";
            display += "<th>State</th>";
            display += "<th>Action</th>";
            display += "<tr/>";
            display += "<body/>";

            Model.m_study study = new Model.m_study();
            string flag = study.lihatData();
            if (flag == "OK")
            {
                foreach (DataRow dr in study.ds.Tables[0].Rows)
                {
                    display += "<tr>";
                    foreach (DataColumn dc in study.ds.Tables[0].Columns)
                    {
                        display += "<td>" + dr[dc.ColumnName].ToString() + "</td>";
                    }
                    display += "<td>";
                    display += "<a href='Editstudy.aspx?id=" + dr[0].ToString() + "'class='btn btn-warning'>Edit</a> ";
                    display += "<a href='Deletestudy.aspx?id=" + dr[0].ToString() + "'class='btn btn-danger'>Hapus</a> ";
                    display += "</td>";
                    display += "</tr>";
                }
                display += "</tbody>";
                display += "</table>";
                lt_table.Text = display;
            }
            else
            {
                lt_table.Text = "Tidak ada data tersedia";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*private void clearData()
        {
            txtKodeJurusan.Text = "";
            txtNamaJurusan.Text = "";
        }*/

        protected void btnSimpan_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("dd-MM-yyyy HH:mm:ss");
            Model.m_study study = new Model.m_study();
            study.StudyId = Convert.ToInt32(txtStudyId.Text);
            study.VersionId = Convert.ToInt32(txtVersionId.Text);
            study.ProtocolTitle = txtProtocolTitle.Text;
            study.ProtocolCode = txtProtocolCode.Text;
            study.MoleculesID = Convert.ToInt32(txtMoleculesId.Text);
            study.StudyStatusID = Convert.ToInt32(txtStudyStatusID.Text);
            study.IsActive = 0;
            study.IsDeleted = 0;
            study.CreatedBy = txtCreatedBy.Text;
            study.CreatedDate = formattedDateTime;
            study.State = txtState.Text;
            string flag = study.insertData();
            if (flag == "OK")
            {
                response.Text = GlobalVariable.getSuccess("Data berhasil disimpan");
                Response.Redirect("jurusan.aspx");
            }
            else
            {
                response.Text = GlobalVariable.getFail("Data gagal disimpan");
            }
        }
    }
}