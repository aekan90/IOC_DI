namespace IOC_DI.ConsoleApp
{
    class DALFactory
    {
        // factory pattern ile IOC implemantasyonu
        // Factory pattern ile BL içerisinde new ile DAL üretmek yerine
        // DAL üreten bir Factroy pattern yazdık.
        // Factory Pattern : Factory (Fabrika) tasarım deseni sınıf yaratma üzerine kurulu bir yapıdır.
        public static IDAL GetDal()
        {
            return new DAL();
        }

    }
}