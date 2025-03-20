<script>
    document.addEventListener("DOMContentLoaded", function () {
    var signInBtn = document.getElementById("sign-in-btn");
    var signUpBtn = document.getElementById("sign-up-btn");
    var continueBtn = document.getElementById("continue-btn");
    var passwordField = document.getElementById("password-field");
    var confirmPasswordField = document.getElementById("confirm-password-field");
    var emailInput = document.getElementById("user-email");
    var isSignUp = false; // Biến để kiểm tra người dùng đang ở chế độ Sign In hay Sign Up

    // Xử lý khi bấm Sign Up
    signUpBtn.addEventListener("click", function () {
        isSignUp = true;
    signUpBtn.classList.add("active");
    signInBtn.classList.remove("active");

    // Hiển thị các ô mật khẩu khi đăng ký
    passwordField.style.display = "block";
    confirmPasswordField.style.display = "block";

    // Đổi nội dung nút Continue thành "Sign Up"
    continueBtn.textContent = "Sign Up";
    });

    // Xử lý khi bấm Sign In
    signInBtn.addEventListener("click", function () {
        isSignUp = false;
    signInBtn.classList.add("active");
    signUpBtn.classList.remove("active");

    // Ẩn các ô mật khẩu khi quay lại Sign In
    passwordField.style.display = "none";
    confirmPasswordField.style.display = "none";

    // Đổi nội dung nút Continue thành "Continue"
    continueBtn.textContent = "Continue";
    });

    // Xử lý khi bấm nút Continue hoặc Sign Up
    continueBtn.addEventListener("click", function () {
        if (emailInput.value.trim() === "") {
        alert("Vui lòng nhập email!");
    return;
        }

    if (isSignUp) {
            var password = document.getElementById("user-password").value;
    var confirmPassword = document.getElementById("confirm-password").value;

    if (password.trim() === "" || confirmPassword.trim() === "") {
        alert("Vui lòng nhập mật khẩu và xác nhận mật khẩu!");
    return;
            }

    if (password !== confirmPassword) {
        alert("Mật khẩu xác nhận không khớp!");
    return;
            }

    alert("Đăng ký thành công!"); // Thay bằng AJAX gửi dữ liệu lên server
        } else {
        // Nếu đang ở chế độ Sign In, chỉ yêu cầu nhập mật khẩu
        passwordField.style.display = "block";
    continueBtn.textContent = "Login";
    continueBtn.type = "submit"; // Khi bấm tiếp sẽ gửi form
        }
    });
});
</script>