using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace TesKalbe.Model
{
    public class m_study
    {
        public string ID, ProtocolTitle, ProtocolCode, CreatedBy, CreatedDate,
            UpdateBy, UpdateDate, State;

        public int StudyId, VersionId, MoleculesID, StudyStatusID, IsActive, IsDeleted;
        SqlConnection myConnection = new SqlConnection();
        string flag;
        public DataSet ds = new DataSet();
        public string insertData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariable.connString;
                myConnection.Open();
                string query = "insert into m_study values(@StudyId, @VersionId,@ProtocolTitle, @ProtocolCode, @MoleculesID, @StudyStatusID, @IsActive, @IsDeleted, @CreatedBy, @CreatedDate, @UpdateBy, @UpdateDate, @State)";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@StudyId", StudyId);
                com.Parameters.AddWithValue("@VersionId", VersionId);
                com.Parameters.AddWithValue("@ProtocolCode", ProtocolCode);
                com.Parameters.AddWithValue("@MoleculesID", MoleculesID);
                com.Parameters.AddWithValue("@StudyStatusID", StudyStatusID);
                com.Parameters.AddWithValue("@IsActive", IsActive);
                com.Parameters.AddWithValue("@IsDeleted", IsDeleted);
                com.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                com.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                com.Parameters.AddWithValue("@UpdateBy", UpdateBy);
                com.Parameters.AddWithValue("@UpdateDate", UpdateDate);
                com.Parameters.AddWithValue("@State", State);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "OK";
                }
                else
                {
                    flag = "FAIL";
                }
            }
            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                    myConnection = null;
                }
            }
            return flag;
        }
        public string editData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariable.connString;
                myConnection.Open();
                string query = "update m_study set StudyId = @StudyId, VersionId = @VersionId, ProtocolCode = @ProtocolCode, MoleculesID = @MoleculesID " +
                    "StudyStatusID=@StudyStatusID, IsActive=@IsActive, IsDeleted=@IsDeleted, CreatedBy=@CreatedBy, UpdateBy=@UpdateBy, UpdateDate=@UpdateDate, State=@State where StudyId = @StudyId";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@StudyId", StudyId);
                com.Parameters.AddWithValue("@VersionId", VersionId);
                com.Parameters.AddWithValue("@ProtocolCode", ProtocolCode);
                com.Parameters.AddWithValue("@MoleculesID", MoleculesID);
                com.Parameters.AddWithValue("@StudyStatusID", StudyStatusID);
                com.Parameters.AddWithValue("@IsActive", IsActive);
                com.Parameters.AddWithValue("@IsDeleted", IsDeleted);
                com.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                com.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                com.Parameters.AddWithValue("@UpdateBy", UpdateBy);
                com.Parameters.AddWithValue("@UpdateDate", UpdateDate);
                com.Parameters.AddWithValue("@State", State);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "OK";
                }
                else
                {
                    flag = "FAIL";
                }
            }
            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                    myConnection = null;
                }
            }
            return flag;
        }
        public string hapusData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariable.connString;
                myConnection.Open();
                string query = "delete m_study where StudyId = @StudyId";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@id", ID);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "OK";
                }
                else
                {
                    flag = "FAIL";
                }
            }
            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                    myConnection = null;
                }
            }
            return flag;
        }

        public string lihatData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariable.connString;
                myConnection.Open();
                string query = "select * from m_study";
                SqlDataAdapter da = new SqlDataAdapter(query, myConnection);
                da.Fill(ds, "m_study");
                flag = "OK";
            }
            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                    myConnection = null;
                }
            }
            return flag;
        }
        public ArrayList cariData()
        {
            ArrayList data = new ArrayList();
            SqlDataReader dr = null;
            try
            {
                myConnection.ConnectionString = GlobalVariable.connString;
                myConnection.Open();
                string query = "select * from m_study where StudyId= @StudyId";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@StudyId", StudyId);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    data.Add(dr[0].ToString());
                    data.Add(dr[1].ToString());
                    data.Add(dr[2].ToString());
                    data.Add(dr[3].ToString());
                    data.Add(dr[4].ToString());
                    data.Add(dr[5].ToString());
                    data.Add(dr[6].ToString());
                    data.Add(dr[7].ToString());
                    data.Add(dr[8].ToString());
                    data.Add(dr[9].ToString());
                    data.Add(dr[10].ToString());
                    data.Add(dr[11].ToString());
                    data.Add(dr[12].ToString());
                    data.Add(dr[13].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                dr = null;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                    myConnection = null;
                }
            }
            return data;
        }
    }
}