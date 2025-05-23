AOS.init({
    duration: 800,
    once: true,
});

// Initialize Bootstrap tooltips
const tooltipTriggerList = document.querySelectorAll(
    '[data-bs-toggle="tooltip"]'
);
const tooltipList = [...tooltipTriggerList].map(
    (tooltipTriggerEl) => new bootstrap.Tooltip(tooltipTriggerEl)
);

document.querySelectorAll(".view-details").forEach((button) => {
    button.addEventListener("click", function () {
        const card = this.closest(".card");
        const modal = document.getElementById("productModal");

        modal.querySelector(".modal-title").textContent = card.dataset.name;
        modal.querySelector(".modal-image").src = card.dataset.image;
        modal.querySelector(
            ".modal-image"
        ).alt = `Hình ảnh ${card.dataset.name}`;
        modal.querySelector(".new-price").textContent = card.dataset.newPrice;
        modal.querySelector(".old-price").textContent = card.dataset.oldPrice;
        modal.querySelector(".modal-description").textContent =
            card.dataset.description;

        const details = JSON.parse(card.dataset.details);
        modal.querySelector(".modal-origin").textContent = details.origin;
        modal.querySelector(".modal-weight").textContent = details.weight;
        modal.querySelector(".modal-temperament").textContent =
            details.temperament;
        modal.querySelector(".modal-health").textContent = details.health;

        modal.querySelector(".modal-buy-now").href = "#";
    });
});