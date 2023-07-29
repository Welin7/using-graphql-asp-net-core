using ProjectGraphQL.Models;
using ProjectGraphQL.Service;

namespace ProjectGraphQL.Mutation
{
    public class MutationMusicCollection
    {
        public string InsertMusicToCollection(Music music)
        {
            var musicCollection = MusicCollectionService.FromJson();
            musicCollection.Musics.Add(music);
            MusicCollectionService.ToJson(musicCollection);

            return "OK";
        }
    }
}