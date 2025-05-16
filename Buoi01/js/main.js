
  document.querySelectorAll('.navbar-nav .nav-link').forEach((link) => {
    link.addEventListener('mouseenter', function () {
      // Gỡ class 'active' khỏi tất cả
      document
        .querySelectorAll('.navbar-nav .nav-link')
        .forEach((el) => el.classList.remove('active'));

      // Gán class 'active' cho phần tử đang hover
      this.classList.add('active');
    });
  });

