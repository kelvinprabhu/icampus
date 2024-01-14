create table share(sharedescription varchar(50),FOREIGN KEY(userid) REFERENCES user_details(userid),sharetype varchar(50));
