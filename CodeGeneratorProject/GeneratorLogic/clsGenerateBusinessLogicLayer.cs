using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeneratorLogic
{
    public class clsGenerateBusinessLogicLayer
    {
        private string _DataBaseName;
        private string _TableName;
        private string _SingleTableName;
        private List<clsColumn> _Columns;


        public clsGenerateBusinessLogicLayer(string DataBaseName, string TableName,string SingleTableName, List<clsColumn> Columns)
        {
            this._DataBaseName = DataBaseName;
            this._TableName = TableName;
            this._SingleTableName = SingleTableName;
            this._Columns = Columns;
        }


        private string _FillMembersWithDataType(string ColumnDataType)
        {
            string DataType = "";

            if (ColumnDataType == "string")
                DataType = @"""""";
            else if (ColumnDataType == "char")
                DataType = "' '";
            else if (ColumnDataType == "bool")
                DataType = "false";
            else
                DataType = "-1";

            return DataType;
        }
        private string _GenerateConstructors()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public cls{_SingleTableName}()
        {{");

            foreach (clsColumn column in _Columns)
            {
                sb.Append($@"
            this.{column.ColumnName} = {_FillMembersWithDataType(column.ColumnDataType)};
            ");
            }

            sb.Append($@" 
            Mode = enMode.AddNew;
        }}");

            sb.Append($@"
        private cls{_SingleTableName}({clsUtil.GetParametersWithDataTypesAndPK(_Columns)})
        {{");

            foreach (clsColumn column in _Columns)
            {
                sb.Append($@"
            this.{column.ColumnName} = {column.ColumnName};
            ");
            }

            sb.Append($@" 
            Mode = enMode.Update;
        }}");

            return sb.ToString();
        }
        private string _MembersSetAndGet()
        {
            StringBuilder sb = new StringBuilder();

            foreach(clsColumn column in _Columns)
            {
                sb.AppendLine($@"
        public {column.ColumnDataType} {column.ColumnName} {{ get; set; }}");
            }

            return sb.ToString();
        }
        private string _GenerateMembers()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public enum enMode {{ AddNew = 0 , Update = 1 }}
        public enMode Mode = enMode.AddNew;

        {_MembersSetAndGet()}");
        
            return sb.ToString();
        }
        private string _DefinedMembers()
        {
            StringBuilder sb = new StringBuilder();

            foreach (clsColumn column in _Columns)
            {
                if (column.IsPK == true)
                    continue;

                sb.Append($@"
            {column.ColumnDataType} {column.ColumnName};
            ");
            }

            return sb.ToString();
        }


        private string _Create()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        private bool _AddNew{_SingleTableName}()
        {{
            this.{_Columns[0].ColumnName} = cls{_TableName}.Create{_SingleTableName}({clsUtil.GetParametersWithoutDataTypesAndPK(_Columns)});
        
            return (this.{_Columns[0].ColumnName} != -1);
        }}");

            return sb.ToString();
        }
        private string _Read()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public static DataTable GetAll{_TableName}()
        {{
            return cls{_TableName}.Read{_TableName}();
        }}");

            return sb.ToString();
        }
        private string _Update()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        private bool _Update{_SingleTableName}()
        {{        
            return cls{_TableName}.Update{_SingleTableName}({clsUtil.GetParameters(_Columns)});
        }}");

            return sb.ToString();
        }
        private string _Delete()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public static bool Delete{_SingleTableName}(int {_Columns[0].ColumnName})
        {{        
            return cls{_TableName}.Delete{_SingleTableName}({_Columns[0].ColumnName});
        }}");

            return sb.ToString();
        }
        private string _Save()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public bool Save()
        {{        
            switch(Mode)
            {{
                case enMode.AddNew:
                    if(_AddNew{_SingleTableName}())
                    {{
                        Mode = enMode.Update;
                        return true;
                    }}
                    break;
                case enMode.Update:
                    return _Update{_SingleTableName}();
                    break;
            }}

            return false;        
        }}");

            return sb.ToString();
        }
        private string _FindByID()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public static cls{_SingleTableName} Find{_SingleTableName}ByID(int {_Columns[0].ColumnName})
        {{  
            {_DefinedMembers()}

            if (cls{_TableName}.Get{_SingleTableName}InfoByID({_Columns[0].ColumnName}, {clsUtil.GetParametersWithoutDataTypesAndPK(_Columns,"ref ")}))
                return new cls{_SingleTableName}({clsUtil.GetParameters(_Columns)});
            else
                return null;
        }}");

            return sb.ToString();
        }



        private void _SaveClass(StringBuilder sb)
        {
            // 1. Folder to save the generated class file
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BusinessAndDataAccessLayers");
            Directory.CreateDirectory(folderPath);

            // 2. Class name
            string className = $"cls{_SingleTableName}";

            // 3. Full file path
            string filePath = Path.Combine(folderPath, $"{className}.cs");

            // 5. Write the class to the file
            File.WriteAllText(filePath, sb.ToString());
        }


        public void Generate()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"﻿using System.Data;
using {_DataBaseName}DataAccessLayer;
         
namespace {_DataBaseName}BusinessLayer
{{
    public class cls{_SingleTableName}
    {{
        {_GenerateMembers()}
        {_GenerateConstructors()}
        {_Read()}
        {_FindByID()}
        {_Create()}
        {_Update()}
        {_Delete()}
        {_Save()}
    }}
}}");

            _SaveClass(sb);
        }
    }
}
