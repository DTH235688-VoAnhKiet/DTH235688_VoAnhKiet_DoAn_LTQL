-- Chạy lệnh này để biến ông ID số 5 thành Admin (số 1)
UPDATE [NhanVien] 
SET [QuyenHan] = 1 
WHERE [ID] = 8;

-- Chạy lệnh này để những ai có Ghi chú là NV thành số 0 (Nhân viên)
UPDATE [NhanVien] 
SET [QuyenHan] = 0 
WHERE [GhiChu] = 'NV';