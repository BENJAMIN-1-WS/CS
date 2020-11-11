;using System;
class SchoolProject
{
    class Parent// אבא
    {
        private string id;//ת.זהות אבא 
        private string name;// שם האבא
        private string cellnum;// טלפון של האבא
        public Parent(string name,string cellnum,string id)// בנאי אבא 
        {
            this.id = id;
            this.name = name;
            this.cellnum = cellnum;
        }
        public Parent(Parent p)//בנאי מעתיק אבא
        {
            this.id = p.GetId();
            this.name = p.GetName();
            this.cellnum = p.GetCellNum();
        }
        public string GetId() { return this.id; }//מחזיר ת.זהות אבא
        public string GetName() { return this.name; }//מחזיר שם אבא
        public string GetCellNum() { return this.cellnum; }//מחזיר טלפון אבא
        public void SetCellNum(string s) { this.cellnum = s; }//שינוי טלפון אבא 
        public override string ToString()// מדפיס אבא
        {
            return this.name + " " + this.cellnum;
        }
    }
    class Student//מחלקה סטודנט
    {
        private string id;// מספר סידורי סטודנט
        private string name;//שם סטודנט
        private string phonenum;//טלפון סטודנט
        private Parent parent;//אבא של הסטודנט
        public Student(string name,string phonenum,Parent parent,string id)//בנאי סטודנט
        {
            this.id = id;// מספר סידורי סטודנט
            this.name = name;//שם סטודנט
            this.phonenum = phonenum;//טלפון סטודנט
            this.parent = parent;// אבא של הסטודנט
        }
        public Student(Student s)// בנאי מעתיק
        {
            this.id = s.GetId();
            this.name = s.GetName();
            this.phonenum = s.GetphoneNum();
            this.parent = s.GetParent();
        }
        public string GetId() { return this.id; }// מחזיק מספר סידורי סטודנט
        public string GetName() { return this.name; }//מחזיר שם סטודנט
        public string GetphoneNum() { return this.phonenum; }//מחזיר טלפון סטודנט
        public Parent GetParent() { return this.parent; }//מחזיר אבא של סטודנט
        public void SetPhoneNum(string phone) { this.phonenum = phone; }//שינוי טלפון של סטודנט
        public override string ToString()//מדפיס סטודנט + אבא
        {
            return this.name + " " + this.phonenum + " " + this.parent;
        }
    }
        static void Main(string[] args)
        {


        }
    }
