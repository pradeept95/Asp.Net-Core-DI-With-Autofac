namespace DemoClassLib.Utilities
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData(string name);
    }
}