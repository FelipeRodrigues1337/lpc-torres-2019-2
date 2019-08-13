namespace aula02
{
    public class Gerente
    {
  
        private decimal salario=1000;
        public void aumento(){
        this.salario=this.salario+((this.salario*10)/100);
        }

        public void aumento(decimal valor){
        this.salario=this.salario+((this.salario*valor)/100);
        }
    }
}