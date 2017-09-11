# RandomizeFromDB
A small program using Pokemon to practice utilizing items with a local SQL Database and randomizing them from that DB info.<br><br>

Things to Optimize:<br>
- the DDL needs to go away and the binding of the information from the DB needs to reside within the button click. <br>
OR <br>
- grab the identity information taken from the SELECT statement and randomize from that number.  May eliminate the use of the DDL<br>
OR <br>
- the DDL is hidden to the user, but when I tried to use the Visible property it did not render at all.  I want invisible if that is a thing.<br><br>
- ensure that once a selection has been chosen it is not chosen until the entire list is exhausted. <br>
- play with Xamarin.Forms and SQLite to enable cross platform app usage.<br>

++ the basic usage of the application (communicating a list of info from a database to connect to an app and randomizing the data) is live though and is a good baseline.



