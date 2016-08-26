using LiteDB;

namespace LiteDbStone
{
    public static class sropAllCollections
    {
        public static void DropAllCollections(this LiteDatabase @this)
        {
            foreach (string col in @this.GetCollectionNames())
            {
                @this.DropCollection(col);
            }
        }
    }
}
