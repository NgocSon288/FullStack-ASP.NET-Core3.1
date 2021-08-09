# Chức năng đăng ký
- Client  Gọi API tạo user  và trả về [UserId]

- Client khi tạo thành công thì dùng [UserId] đó để gọi API gửi [Email-Confirm], truyền vào [UserId]

-Server nhận một [UserId] để generate ra [Coke], nhận [ReturlUrl] để khi nhấn vào [Link-Email] nó sẽ chuyển tới [UserId&Code&returnUrl]