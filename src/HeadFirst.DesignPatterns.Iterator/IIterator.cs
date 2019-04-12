namespace HeadFirst.DesignPatterns.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        object Next();

    }
}