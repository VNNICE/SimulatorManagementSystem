namespace DatabaseManager
{
    public class DefaultInfo
    {
        public static readonly string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        public static readonly string imagePath = Path.Combine(dbPath, "Images");

        public void MakeDefaultData()
        {
            if (!Directory.Exists(dbPath))
            {
                Directory.CreateDirectory(dbPath);
            }
            if (!Directory.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }
            using (var context = new DBContext())
            {
                context.Database.EnsureCreated();
            }
        }
}
