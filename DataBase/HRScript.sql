alter table NHANVIEN
add constraint FK_NVPHONGBAN foreign key (MaPB) references PHONGBAN(MaPB)