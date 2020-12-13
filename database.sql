use QLTT
create table PHONG(
	ma_phong varchar(10) primary key not null,
	ten_phong nvarchar(30) not null,
	sdt varchar(10)
);
insert into PHONG
values('101',N'Kế toán','099992222');
insert into PHONG
values('102',N'Nhân sự','099992223');
insert into PHONG
values('103',N'Dev 1','099992225');
insert into PHONG
values('104',N'Dev 2','099992226');
insert into PHONG
values('101',N'Dev 3','099992221');

create table PROJECT(
	ma_du_an varchar(10) primary key not null,
	ten_du_an nvarchar(30) not null,
	bat_dau_du_an datetime,
	ket_thuc_du_an datetime,
)
insert into PROJECT
values('DA1',N'Bluedon','2020-07-01','2020-08-01');
insert into PROJECT
values('DA2',N'Redzone','2020-06-01','2020-10-10');
insert into PROJECT
values('DA3',N'Dựng phim quảng cáo','2020-10-01','2020-12-01');
insert into PROJECT
values('DA4',N'Book đánh giày','2020-09-12','2021-01-01');
insert into PROJECT
values('DA5',N'Book đánh răng','2020-11-11','2021-02-02');

select * from PROJECT

create table THUC_TAP(
	ma_tts varchar(10) primary key not null,
	ho_ten nvarchar(50) not null,
	email varchar(30),
	DOB date,
	bat_dau_thuc_tap date,
	ket_thuc_thuc_tap date,
	ma_phong_thuc_tap varchar(10) foreign key REFERENCES  PHONG(ma_phong),
)
insert into THUC_TAP
values('TT001',N'Nguyễn Văn Minh','nguyenvanminh@gmail.com','1997-01-01','2020-07-02','2020-10-10','101');
insert into THUC_TAP
values('TT002',N'Nguyễn Văn Hải','nguyenvanhai@gmail.com','1999-10-10','2020-09-02','2020-10-20','102');
insert into THUC_TAP
values('TT003',N'Nguyễn Thị Minh','nguyenthiminh@gmail.com','1998-12-03','2020-09-20','2020-11-21','103');
insert into THUC_TAP
values('TT004',N'Trần Tiến Minh','trantienminh@gmail.com','1999-01-01','2020-06-30','2020-10-22','104');
insert into THUC_TAP
values('TT005',N'Trần Thanh Tùng','tranthanhtung@gmail.com','1999-02-21','2019-01-02','2020-12-10','105');
insert into THUC_TAP
values('TT006',N'Nguyễn Minh Hằng','nguyenminhhang@gmail.com','1997-01-01','2020-07-02','2020-10-10','101');
insert into THUC_TAP
values('TT007',N'Lê Thị Trang','lethingoc@gmail.com','1992-01-01','2020-10-20',null,'103');

drop table THUC_TAP

select * from TH




