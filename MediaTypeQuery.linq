<Query Kind="Statements">
  <Connection>
    <ID>cac27cb5-def5-4e04-9231-5bacaeb8e6db</ID>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
			  select new
			  {
			   Name = m.Name,
			   Tracks = from t in m.Tracks
			   			select new
				{
					TrackName = t.Name,
					Album =  t.Album.Title,
					Artist = t.Album.Artist.Name,
					ReleaseYear = t.Album.ReleaseYear,
					ReleaseLabel = t.Album.ReleaseLabel, 
					Genre =  t.Genre.Name
				}
			  };
			
results.Dump();