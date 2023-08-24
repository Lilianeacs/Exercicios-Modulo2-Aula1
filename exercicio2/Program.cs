namespace exercicio2
{
    //Corrija o erro
    public abstract class Funcionario
    {
        public abstract void getBonificacao();
    }

    public abstract class Secretaria
    {

    }

    public class SecretariaAdministrativa : Funcionario
    {
        public override void getBonificacao()
        {
            //..
        }
    }

    public class SecretariaAgencia : Funcionario
    {
        public override void getBonificacao()
        {
            //..
        }
    }

    public class Presidente : Funcionario
    {
        public override void getBonificacao()
        {
            //..
        }
    }

    public abstract class Gerente : Funcionario
    {
        public override void getBonificacao()
        {
            //..
        }
    }

    public class Diretor : Gerente
    {

    }
}