<Query Kind="Statements">
  <Connection>
    <ID>cac27cb5-def5-4e04-9231-5bacaeb8e6db</ID>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
			  where g.Name.Equals("Heavy Metal")
			  select new
			  {
				TracksCount = g.Tracks.Count(),
				Tracks = from t in g.Tracks
						select new
				{
					TrackName = t.Name,
					AlbumName = t.Album.Title,
					Milliseconds = t.Milliseconds,
					size = (t.Bytes/1000)+"kb",
					Price = t.UnitPrice
				}
			  };
results.Dump("Query Math 2");