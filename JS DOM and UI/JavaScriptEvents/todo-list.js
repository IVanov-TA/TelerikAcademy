var btnAdd = document.getElementById("add");
var divWrapper = document.getElementById("wrapper");
var clearBtn = document.createElement("button");
clearBtn.innerHTML = "Clear List";
document.body.appendChild(clearBtn);

function createInput() {
    var input = document.createElement("input");
    input.style.width = "150px";
    input.id = "inputItem";
    divWrapper.appendChild(input);
    divWrapper.appendChild(btnAdd);
}
createInput();

function getValue() {
    var item = document.getElementById("inputItem").value;
    return item;
}

var list = document.createElement("ol");
var emptyList = document.createElement("div");

btnAdd.onclick = function displayList() {
    var value = getValue();
    if (value == '') {
        emptyList.innerHTML = "The input field is empty!";
        document.body.appendChild(emptyList);
    }
    else {
        var btnDelete = document.createElement("button");
        btnDelete.style.position = "absolute";
        btnDelete.style.left = "260px";
        var li = document.createElement("li");
        li.innerHTML = value;
        list.appendChild(li);
        btnDelete.innerHTML = "X";
        li.appendChild(btnDelete);
        emptyList.innerHTML = "";
        btnDelete.addEventListener('click', function (event) {
            removeSingleItem(event.target.parentNode);
        });
    }

    divWrapper.appendChild(list);
}

clearBtn.onclick = function clearList() {
    while (list.firstChild) {
        list.removeChild(list.firstChild);
    }
}

var removeSingleItem = function removeSingleItem(itemToDelete) {
    itemToDelete.parentNode.removeChild(itemToDelete);
};