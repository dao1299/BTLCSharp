use QLTT
create table PHONG(
	ma_phong varchar(10) primary key not null,
	ten_phong nvarchar(30) not null,
	sdt varchar(10)
);

select * from phong
insert into PHONG
values('106',N'Dev 3','099992222',N'Lê Văn Toàn');
insert into PHONG
values('102',N'Nhân sự','099992223');
insert into PHONG
values('103',N'Dev 1','099992225');
insert into PHONG
values('104',N'Dev 2','099992226');
insert into PHONG
values('105',N'Dev 3','099992221');

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

use qltt
drop table THUC_TAP
create table thuc_tap(
	ma_tts varchar(10) primary key not null,
	ho_ten nvarchar(50) not null,
	email varchar(30),
	DOB date,
	bat_dau_thuc_tap date,
	ket_thuc_thuc_tap date,
	ma_phong_thuc_tap varchar(10) foreign key REFERENCES  PHONG(ma_phong) on delete set null on update cascade,
)
insert into thuc_tap
values('TT001',N'Nguyễn Văn Minh','nguyenvanminh@gmail.com','1997-01-01','2020-07-02','2020-10-10','101');
insert into THUC_TAP
values('TT002',N'Nguyễn Văn Hải','nguyenvanhai@gmail.com','1999-10-10','2020-09-02','2020-10-20','102');
insert into thuc_tap
values('TT003',N'Nguyễn Thị Minh','nguyenthiminh@gmail.com','1998-12-03','2020-09-20','2020-11-21','103');
insert into THUC_TAP
values('TT004',N'Trần Tiến Minh','trantienminh@gmail.com','1999-01-01','2020-06-30','2020-10-22','104');
insert into THUC_TAP
values('TT005',N'Trần Thanh Tùng','tranthanhtung@gmail.com','1999-02-21','2019-01-02','2020-12-10','105');
insert into THUC_TAP
values('TT006',N'Nguyễn Minh Hằng','nguyenminhhang@gmail.com','1997-01-01','2020-07-02','2020-10-10','101');
insert into THUC_TAP
values('TT007',N'Lê Thị Trang','lethingoc@gmail.com','1992-01-01','2020-10-20',null,'103');
insert into THUC_TAP
values('TT008',N'Lê Thị Xuân','lethixuan@gmail.com','1991-01-01','2020-12-20',null,'104');
insert into THUC_TAP
values('TT009',N'Hoàng Thị Huế','hoangthihue@gmail.com','1997-02-12','2020-09-10',null,'103');


select * from phong
alter table phong
add nguoi_quan_ly nvarchar(30)

use qltt

select * from taikhoan

delete from taikhoan
where username='123'

alter table taikhoan
add constraint username unique(username)

select * from taikhoan where username='admin'

insert into taikhoan values ('dao','dao',2)

update taikhoan set password='12345', status=2 where username='dao'

delete from work 
where ma_tts='TT009' 

select * from work

insert into work values ('TT001','DA1',N'Đã hoàn thành')
insert into work values ('TT002','DA1',N'Đã hoàn thành')
insert into work values ('TT003','DA2',N'Đã hoàn thành')
insert into work values ('TT004','DA2',N'Đã hoàn thành')
insert into work values ('TT005','DA3',N'Đã hoàn thành')
insert into work values ('TT006','DA3',N'Đã hoàn thành')
insert into work values ('TT007','DA3',N'Đã hoàn thành')
insert into work values ('TT008','DA5',N'Đã hoàn thành')
insert into work values ('TT001','DA5',N'Đang làm')
insert into work values ('TT002','DA5',N'Đang làm')
insert into work values ('TT009','DA4',N'Đã hoàn thành')
select * from work

alter table work
add constraint unique_ma_tts unique(ma_tts,ma_du_an);

select * from project

select * from thuc_tap
select * from thuc_tap where ma_tts='TT001'

select * from project where ma_du_an='DA1'

select * from work

update work
set ma_tts='TT002', ma_du_an='DA1' , tinh_trang=N'Đã hoàn thành'
where ma_du_an='DA1' and ma_tts='TT002'

alter table thuc_tap
add gioi_tinh nvarchar(5)



select * from thuc_tap

select count(ma_tts) as Số_lượng, ma_phong_thuc_tap from thuc_tap group by ma_phong_thuc_tap

select count(thuc_tap.ma_tts) as Số_lượng ,phong.ten_phong as Tên_phòng ,phong.ma_phong
from thuc_tap,PHONG 
where thuc_tap.ma_phong_thuc_tap=phong.ma_phong 
group by phong.ten_phong,phong.ma_phong

select count(thuc_tap.ma_tts) as Số_lượng,phong.ten_phong as Tên_phòng ,phong.ma_phong
from thuc_tap,phong 
where not((thuc_tap.bat_dau_thuc_tap <= '2020-07-01' and thuc_tap.ket_thuc_thuc_tap<='2020-07-30') or (thuc_tap.bat_dau_thuc_tap >= '2020-07-01' and thuc_tap.ket_thuc_thuc_tap>='2020-07-30')) and thuc_tap.ma_phong_thuc_tap=phong.ma_phong 
group by phong.ma_phong,PHONG.ten_phong

select * from thuc_tap 
where not((bat_dau_thuc_tap <= '2020-07-01' and ket_thuc_thuc_tap<='2020-07-30') or (bat_dau_thuc_tap >= '2020-07-01' and ket_thuc_thuc_tap>='2020-07-30'))

select * from work

select count(*) as Số_lượng_công_việc,tinh_trang as Tình_trạng from work where ma_tts='TT002' group by tinh_trang