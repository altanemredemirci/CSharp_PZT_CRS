namespace _17_OOP_5_Abstract_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             User    :Create,Update,Delete,List,Find
             Product :Create,Update,Delete,List,Find
             Category:Create,Update,Delete,List,Find
             Brand   :Create,Update,Delete,List,Find
             Cart    :Create,Update,Delete,List,Find
             Order   :Create,Update,Delete,List,Find
             
             */

            Cart cart = new Cart();
            cart.Find();
        }
    }

    abstract class Base
    {
        public abstract void Create();
        public abstract void Update();
        public abstract void Delete();
        public abstract void List();
        public abstract void Find();
    }

    class User : Base
    {
        public override void Create()
        {

        }

        public override void Update()
        {

        }

        public override void Delete()
        {

        }

        public override void List()
        {

        }

        public override void Find()
        {

        }
    }

    class Cart : Base
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Find()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
