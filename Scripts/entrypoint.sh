#!/bin/bash
database=master
password=TestTest123

echo importing data...

/opt/mssql-tools/bin/sqlcmd -S 0.0.0.0 -U sa -P $password -i ./init.sql
