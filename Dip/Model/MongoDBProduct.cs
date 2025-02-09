namespace Dip.Factory
{
    internal class MongoDBProduct : IDbProduct
    {
        public string GetProductById(string id)
        {
            return $"Mongo: Exibindo dados do produto {id}.";
        }
    }
}