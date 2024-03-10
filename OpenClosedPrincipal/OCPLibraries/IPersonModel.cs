namespace OCPLibraries
{
    public interface IPersonModel
    {
        string firstName { get; set; }
        string lastName { get; set; }
        IAccounts accountProcessor { get; set; }
    }
}