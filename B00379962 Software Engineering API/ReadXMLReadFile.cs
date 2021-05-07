namespace DataAccessManager
{
    public abstract class ReadFile
    {

        public abstract object Read();

        public virtual string Finish()
        {
            string Text = "Finished Reading Selected File";
            return Text;
        }



        // The template method
        public void Create()
        {

                Read();
                Finish();

        }
    }
}
