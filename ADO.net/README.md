1. ADO.NET Architecture
ADO.NET consists of two main components:
•	Connected Architecture: Uses DataReader for fast, forward-only, read-only access to data.
•	Disconnected Architecture: Uses DataSet, DataTable, and DataAdapter for working with data in memory.

2. Key Components
•	Connection: Establishes a connection to a data source.
•	Command: Executes SQL queries and stored procedures.
•	DataReader: Reads data from a data source in a forward-only manner.
•	DataAdapter: Fills a DataSet and updates the data source.
•	DataSet: An in-memory representation of data.
•	DataTable: Represents a single table of data.
•	DataView: Provides a customizable view of a DataTable.
