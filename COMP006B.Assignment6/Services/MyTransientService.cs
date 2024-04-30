namespace COMP006B.Assignment6.Services
{
    public class MyTransientService
    {
        //private field
        private readonly Guid _uniqueId;

        //default constrcutor
        public MyTransientService()
        {
            _uniqueId = Guid.NewGuid();
        }

        //public method that returns the _uniqueId value
        public Guid GetUniqueID()
        {
            return _uniqueId;
        }
    }
}
