namespace exercicio_crud.Models
{
    public class Person
    {
        public Person(){}
        public Person(int id, string name, string adress){
            this.id = id;
            this.name = name;
            this.adress = adress;
        }

        public int  id { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
    }
}