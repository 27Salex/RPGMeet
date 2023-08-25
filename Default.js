const slider = document.querySelector('div .slider');
const sliderContentList = Array.from(document.querySelectorAll('.slider-content'));


function getTransformXY(element) {
    const style = window.getComputedStyle(element);
    const matrix = new DOMMatrixReadOnly(style.transform);
    return {
        transformX: matrix.m41,
        transformY: matrix.m42
    }
}

function moveSliderContent(sliderContent, posX, posY) {
    sliderContent.style.transform = `translate(${posX}px, ${posY}px)`;
}

//check
function UpdateMain(direction) {
    //Obtiene el contenido central denominado con la clase 'main'
    let main = sliderContentList.findIndex(element => element.classList.contains('main'));
    //eliminamos el main actual para posteriormente pasarselo al siguiente correspondiente
    sliderContentList[main].classList.remove('main');

    main += parseInt(direction);
    if (main < 0)
        main = sliderContentList.length - 1;
    if (main > sliderContentList.length - 1)
        main = 0;
    sliderContentList[main].className += ' main';
    return main;
}

//check
function UpdateZIndex(main, direction) {
    if (direction < 0) {
        switch (main) {
            case 0:
                sliderContentList[2].style.zIndex = 0;
                sliderContentList[1].style.zIndex = 1;
                break;
            case 1:
                sliderContentList[0].style.zIndex = 0;
                sliderContentList[2].style.zIndex = 1;
                break;
            case 2:
                sliderContentList[1].style.zIndex = 0;
                sliderContentList[0].style.zIndex = 1;
                break;
        }
    }
    else if (direction > 0) {
        switch (main) {
            case 0:
                sliderContentList[1].style.zIndex = 0;
                sliderContentList[2].style.zIndex = 1;
                break;
            case 1:
                sliderContentList[2].style.zIndex = 0;
                sliderContentList[0].style.zIndex = 1;
                break;
            case 2:
                sliderContentList[0].style.zIndex = 0;
                sliderContentList[1].style.zIndex = 1;
                break;
        }
    }
    sliderContentList[main].style.zIndex = 2;
}

function SlideCarrousel(event) {
    const direction = event.target.value;
    if (direction < 0) {
        moveSliderContent(sliderContentList[0], getTransformXY(sliderContentList[1]).transformX, getTransformXY(sliderContentList[1]).transformY);
        moveSliderContent(sliderContentList[1], getTransformXY(sliderContentList[2]).transformX, getTransformXY(sliderContentList[2]).transformY);
        moveSliderContent(sliderContentList[2], getTransformXY(sliderContentList[0]).transformX, getTransformXY(sliderContentList[0]).transformY);
    }
    else if (direction > 0) {
        moveSliderContent(sliderContentList[2], getTransformXY(sliderContentList[1]).transformX, getTransformXY(sliderContentList[1]).transformY);
        moveSliderContent(sliderContentList[1], getTransformXY(sliderContentList[0]).transformX, getTransformXY(sliderContentList[0]).transformY);
        moveSliderContent(sliderContentList[0], getTransformXY(sliderContentList[2]).transformX, getTransformXY(sliderContentList[2]).transformY);
    }
    UpdateZIndex(UpdateMain(direction), direction);
}

document.addEventListener('DOMContentLoaded', function () {
    const sliderLeftBtn = document.getElementById('slider-left-btn');
    const sliderRightBtn = document.getElementById('slider-right-btn');

    sliderLeftBtn.addEventListener('click', handleButtonClick);
    sliderRightBtn.addEventListener('click', handleButtonClick);
});

function handleButtonClick(event) {
    const clickedButton = event.target;

    if (clickedButton.id === 'slider-left-btn' || clickedButton.id === 'slider-right-btn') {
        const sliderLeftBtn = document.getElementById('slider-left-btn');
        const sliderRightBtn = document.getElementById('slider-right-btn');

        if (!sliderLeftBtn.disabled && !sliderRightBtn.disabled) {
            sliderLeftBtn.disabled = true;
            sliderRightBtn.disabled = true;

            setTimeout(() => {
                sliderLeftBtn.disabled = false;
                sliderRightBtn.disabled = false;
            }, 1000);

            SlideCarrousel(event);
        }
    }
}