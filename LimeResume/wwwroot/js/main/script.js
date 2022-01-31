const text1_options = [
    "÷ели практики",
    "¬иды де€тельности",
    "Ётапы практики",
    "ќрганизации практики"
];
const text2_options = [
    " омплексное освоение всех видов профессиональной де€тельности по специальности, а также приобретение опыта практической работы по специальности.",
    "«адание, на базе которого студент проходит данную практику, определ€етс€ руководителем практики от организации и согласовываетс€ с руководителем практики от техникума.",
    "ѕроизводственна€ практика включает в себ€ следующие этапы: практика по профилю специальности и преддипломна€ практика.",
    "ѕроизводственна€ практика проводитс€ в организаци€х различных организационно-правовых форм."
];
const color_options = ["#232b3e", "#161E2A", "#2b2c7c", "#302a5a"];
const image_options = [
    "https://thumbs.dreamstime.com/b/%D0%B1%D0%B5%D0%BB%D1%8B%D0%B9-%D1%87%D0%B5%D0%BB%D0%BE%D0%B2%D0%B5%D0%BA-d-%D1%83%D0%BA%D0%B0%D0%B7%D1%8B%D0%B2%D0%B0%D1%8F-%D0%BF%D0%B0%D0%BB%D0%B5%D1%86-%D0%BD%D0%B0-%D0%BA%D1%80%D0%B0%D1%81%D0%BD%D1%83%D1%8E-%D1%86%D0%B5%D0%BB%D1%8C-123193676.jpg",
    "https://st.depositphotos.com/1654249/1263/i/950/depositphotos_12630371-stock-photo-3d-business-man-showing-thumbs.jpg",
    "https://thumbs.dreamstime.com/b/%D0%BC%D0%B0-%D0%B5%D0%BD%D1%8C%D0%BA%D0%B8%D0%B9-%D1%87%D0%B5-%D0%BE%D0%B2%D0%B5%D0%BA-d-%D1%81%D0%BC%D0%BE%D1%82%D1%80%D0%B8%D1%82-%D1%87%D0%B0%D1%81%D1%82%D1%8C-%D0%BC%D0%BE%D0%B7%D0%B0%D0%B8%D0%BA%D0%B8-46104327.jpg",
    "https://www.meme-arsenal.com/memes/707826bfa976648daa1824b2c9d60bc0.jpg"
];
var i = 0;
const currentOptionText1 = document.getElementById("current-option-text1");
const currentOptionText2 = document.getElementById("current-option-text2");
const currentOptionImage = document.getElementById("image");
const carousel = document.getElementById("carousel-wrapper");
const mainMenu = document.getElementById("menu");
const optionPrevious = document.getElementById("previous-option");
const optionNext = document.getElementById("next-option");

currentOptionText1.innerText = text1_options[i];
currentOptionText2.innerText = text2_options[i];
currentOptionImage.style.backgroundImage = "url(" + image_options[i] + ")";
mainMenu.style.background = color_options[i];

optionNext.onclick = function () {
    i = i + 1;
    i = i % text1_options.length;
    currentOptionText1.dataset.nextText = text1_options[i];

    currentOptionText2.dataset.nextText = text2_options[i];

    mainMenu.style.background = color_options[i];
    carousel.classList.add("anim-next");

    setTimeout(() => {
        currentOptionImage.style.backgroundImage = "url(" + image_options[i] + ")";
    }, 455);

    setTimeout(() => {
        currentOptionText1.innerText = text1_options[i];
        currentOptionText2.innerText = text2_options[i];
        carousel.classList.remove("anim-next");
    }, 650);
};

optionPrevious.onclick = function () {
    if (i === 0) {
        i = text1_options.length;
    }
    i = i - 1;
    currentOptionText1.dataset.previousText = text1_options[i];

    currentOptionText2.dataset.previousText = text2_options[i];

    mainMenu.style.background = color_options[i];
    carousel.classList.add("anim-previous");

    setTimeout(() => {
        currentOptionImage.style.backgroundImage = "url(" + image_options[i] + ")";
    }, 455);

    setTimeout(() => {
        currentOptionText1.innerText = text1_options[i];
        currentOptionText2.innerText = text2_options[i];
        carousel.classList.remove("anim-previous");
    }, 650);
};