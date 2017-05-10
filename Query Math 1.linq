<Query Kind="Statements">
  <Connection>
    <ID>cac27cb5-def5-4e04-9231-5bacaeb8e6db</ID>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
			  orderby g.Name
			  select new
			  {
			  	Genre = g.Name,
				TracksCount = g.Tracks.Count()
			  };
results.Dump("Query Math 1");