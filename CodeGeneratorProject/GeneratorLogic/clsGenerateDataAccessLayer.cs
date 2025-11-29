using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace GeneratorLogic
{
    public class clsGenerateDataAccessLayer
    {
        private string _ConnectionString;
        private string _DataBaseName;
        private string _TableName;
        private string _SingleTableName;
        private List<clsColumn> _Columns;


        public clsGenerateDataAccessLayer(string ConnectionString, string DataBaseName, string TableName, string SingleTableName, List<clsColumn> Columns)
        {
            this._ConnectionString = ConnectionString;
            this._DataBaseName = DataBaseName;
            this._TableName = TableName;
            this._SingleTableName = SingleTableName;
            this._Columns = Columns;
        }

        private static void _SaveClass(StringBuilder sb,string TableName)
        {
            // 1. Folder to save the generated class file
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BusinessAndDataAccessLayers");
            Directory.CreateDirectory(folderPath);
            
            // 2. Class name
            string className = $"cls{TableName}";

            // 3. Full file path
            string filePath = Path.Combine(folderPath, $"{className}.cs");

            // 5. Write the class to the file
            File.WriteAllText(filePath, sb.ToString());
        }


        public void Generate()
        {
            

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"﻿using System; 
using System.Data.SqlClient;
using System.Data;

namespace {_DataBaseName}DataAccessLayer
{{
    public static class DataAccessSettings
    {{
        public static string ConnectionString = ""{_ConnectionString}""
    }}

    public class cls{_TableName}
    {{
        {Create()} 
        {Read()}
        {Update()}
        {Delete()}
        {FindByID()}
    }}
}}");
          
            _SaveClass(sb,_TableName); 
        }


        private string FindByID()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"public static bool Get{_SingleTableName}InfoByID({_Columns[0].ColumnDataType} {_Columns[0].ColumnName},{clsUtil.GetParametersWithDataTypesOnly(_Columns,"ref ")})
        {{
            bool IsFound = false;
            
            try
            {{
                 using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString)) 
                 {{
                    connection.Open();

                    string query = @$""SELECT * FROM {_TableName} WHERE {_Columns[0].ColumnName} = @{_Columns[0].ColumnName};""
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        command.Parameters.AddWithValue(""@{_Columns[0].ColumnName}"",{_Columns[0].ColumnName});

                          using (SqlDataReader reader = command.ExecuteReader())
                          {{
                               if (reader.Read())
                               {{
                                   IsFound = true;
                               
                                   {clsUtil.HandleFindByIDData(_Columns)}
                               }}
                               else
                                   IsFound = false;
                          }}
                    }}
                 }}
            }}
            catch (Exception e)
            {{
                throw e;
            }}          

            return IsFound;
        }}");


            return sb.ToString();
        }
        private string Create()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"public static int Create{_SingleTableName}({clsUtil.GetParametersWithDataTypesOnly(_Columns)})
        {{
            int NewID = -1; 
            
            try
            {{
                 using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString)) 
                 {{
                    connection.Open();

                    string query = @$""Insert into [dbo].[{_TableName}] ({clsUtil.GetParametersWithoutDataTypesAndPK(_Columns)}) 
                                              Values({clsUtil.GetParametersWithoutDataTypesAndPK(_Columns,"@")}); 
                                       Select SCOPE_IDENTITY();""
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        {clsUtil.CreateCommands(_Columns)}

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {{
                            NewID = InsertedID;
                        }}
                    }}
                 }}
            }}
            catch (Exception e)
            {{
                throw e;
            }}          

            return NewID;
        }}");
            

            return sb.ToString();
        }
        private string Read()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"public static DataTable Read{_TableName}()
        {{
            DataTable dt{_TableName} = new DataTable(); 
            
            try
            {{
                 using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString)) 
                 {{
                    connection.Open();

                    string query = @$""SELECT * FROM {_TableName};""
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                   
                        using (SqlDataReader reader = command.ExecuteReader())
                        {{
                            if (reader.HasRows)
                                dt{_TableName}.Load(reader);
                        }}
                    }}
                 }}
            }}
            catch (Exception e)
            {{
                throw e;
            }}          

            return dt{_TableName};
        }}");


            return sb.ToString();
        }
        private string Update()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"public static bool Update{_SingleTableName}({clsUtil.GetParametersWithDataTypesAndPK(_Columns)})
        {{
            int RowsAffected = 0; 
            
            try
            {{
                 using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString)) 
                 {{
                    connection.Open();

                    string query = @$""Update [dbo].[{_TableName}] 
                                       SET 
                                       {clsUtil.UpdateQuery(_Columns)}
                                       WHERE {_Columns[0].ColumnName} = @{_Columns[0].ColumnName}""
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        {clsUtil.UpdateCommands(_Columns)}

                        RowsAffected = command.ExecuteNonQuery();
                    }}
                 }}
            }}
            catch (Exception e)
            {{
                throw e;
            }}          

            return (RowsAffected > 0);
        }}");


            return sb.ToString();
        }
        private string Delete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"public static bool Delete{_SingleTableName}({_Columns[0].ColumnDataType} {_Columns[0].ColumnName})
        {{
            int RowsAffected = 0; 
            
            try
            {{
                 using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString)) 
                 {{
                    connection.Open();

                    string query = @$""Delete From {_TableName} WHERE {_Columns[0].ColumnName} = @{_Columns[0].ColumnName}""
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        command.Parameters.AddWithValue(""@{_Columns[0].ColumnName}"",{_Columns[0].ColumnName});

                        RowsAffected = command.ExecuteNonQuery();
                    }}
                 }}
            }}
            catch (Exception e)
            {{
                throw e;
            }}          

            return (RowsAffected > 0);
        }}");


            return sb.ToString();
        }
    }
}
