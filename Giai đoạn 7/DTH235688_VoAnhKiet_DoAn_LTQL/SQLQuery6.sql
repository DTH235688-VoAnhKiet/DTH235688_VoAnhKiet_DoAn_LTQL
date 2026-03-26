-- 1. Xóa dữ liệu rác trong bảng Bug (nếu có)
DELETE FROM Bug;

-- 2. Chèn 3 dòng Bug vào các dự án ĐANG CÓ SẴN của ný
-- Dự án 4: Hệ thống E-Learning
-- Dự án 5: App Fitness Pro
-- Dự án 6: Web Bán Hàng 2
INSERT INTO Bug (TieuDe, MoTa, MucDo, TrangThai, NgayBaoCao, DuAnID, NguoiBaoCaoID, NguoiXuLyID)
VALUES 
(N'Lỗi đăng nhập E-Learning', N'Dữ liệu không load lên bảng', N'Critical', N'Chưa fix', GETDATE(), 4, 5, 5),
(N'Lỗi thanh toán App Fitness', N'Nút bấm không phản hồi', N'High', N'Đang fix', GETDATE(), 5, 5, 5),
(N'Giao diện Web bị lỗi font', N'Sai hiển thị trên trình duyệt', N'Low', N'Đã fix', GETDATE(), 6, 5, 5);

-- 3. Kiểm tra xem dữ liệu đã vào chưa
SELECT * FROM Bug;