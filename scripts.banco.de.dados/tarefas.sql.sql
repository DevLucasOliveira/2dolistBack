CREATE DATABASE tasklist;

CREATE TABLE tasks(
id int primary key identity(1,1),
task varchar(60) not null,
[done] bit
);

