namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Iterator.GoodSolution
{
    public interface IIterator<T>
    {
        T Next();
        bool HasNext();
        T Current();
    }
}