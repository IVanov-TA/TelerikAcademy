function test() {
    var people = [ { name: "Gosho",age: 32 },
            { name: "Bay",age: 81 },
            { name: "Mitaka", age: 12 }];
    var template = document.getElementById("list-item").innerHTML;
    var peopleList = generateList(people, template);
    document.write(peopleList);
}

function generateList(ppl, tmpl) {
    tmpl = new String(tmpl); //parse to string
    tmpl = tmpl.replace(/<strong>/g, '<li><strong>'); //add <li> tag
    tmpl = tmpl.replace(/<\/span>/g, '</span></li>'); //add</li> tag
    var list = new String('<ul>');//string for keepen the result
    for (var i in ppl) {
        var currentLI = tmpl.replace('-{name}-', ppl[i].name);
        currentLI = currentLI.replace('-{age}-', ppl[i].age);
        list += currentLI;
    }
    list += '</ul>';
    return list;
}