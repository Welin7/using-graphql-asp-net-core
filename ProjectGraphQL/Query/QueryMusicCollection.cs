using ProjectGraphQL.Models;
using ProjectGraphQL.Service;

namespace ProjectGraphQL.Query
{
    public class QueryMusicCollection
    {
        public MusicCollection GetMusicCollection()
        {
            var musicCollection = MusicCollectionService.FromJson();
            return musicCollection;
        }
    }
}