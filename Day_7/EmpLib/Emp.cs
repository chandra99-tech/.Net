using System.ComponentModel.DataAnnotations.Schema;

namespace EmpLib
{
    [Table("Employee")]
    public class Emp
    {
        private int _ID;
        private string _Name;
        private string _Address;

        [Column("EmpID", TypeName = "int")]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        [Column("EmpName", TypeName = "varchar(50)")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        [Column("Address", TypeName = "varchar(50)")]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
    }
}
