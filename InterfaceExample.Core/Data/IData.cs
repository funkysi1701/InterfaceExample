namespace InterfaceExample.Core
{
    public interface IData
    {
        Blog LoadData(string Connectionstring);

        int FindData(string value, Blog blog);
    }
}
