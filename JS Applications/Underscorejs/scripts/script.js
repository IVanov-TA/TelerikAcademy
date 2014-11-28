/**
 * Created by IV Terminal on 22.7.2014 г..
 */
window.onload = function () {
    var Student = Object.create({
        init: function (firstName, lastName, age, grades) {
            this.fname = firstName;
            this.lname = lastName;
            this.age = age;
            this.grades = [].concat(grades);
            return this;
        },
        fullName: function () {
            return  this.fname + ' ' + this.lname;
        },
        averageScore: function () {
            var totalScore = 0,
                avrScore = 0;

            _.each(this.grades, function (grade) {
                totalScore += grade;
            });

            avrScore = totalScore / this.grades.length;

            return avrScore.toFixed(2);
        }
    });

    var Animal = Object.create({
        init: function (name, specie, numberOfLegs) {
            this.name = name;
            this.specie = specie;
            this.numOfLegs = numberOfLegs;
            return this;
        }
    });

    var Book = Object.create({
        init: function (bookName, authorName) {
            this.name = bookName;
            this.author = authorName;
            return this;
        }
    });

    var students = [
        Object.create(Student).init('Pesho', 'Angelov', 14, [2, 2, 3]),
        Object.create(Student).init('Maria', 'Borisova', 26, [6, 5, 4]),
        Object.create(Student).init('Angel', 'Kanchev', 33, [3, 3, 3]),
        Object.create(Student).init('Yavor', 'Yavorov', 21, [4, 4, 4, 6]),
        Object.create(Student).init('Borisa', 'Kancheva', 19, [6, 6, 5]),
        Object.create(Student).init('Mitko', 'Dimitrov', 6, [5, 3, 3]),
        Object.create(Student).init('Gosho', 'Kanchev', 26, [6, 2, 3]),
        Object.create(Student).init('Ivan', 'Vanov', 20, [2, 5, 3]),
        Object.create(Student).init('Gosho', 'Gerasimov', 18, [3, 6, 3]),
        Object.create(Student).init('Boriana', 'Jekova', 26, [6, 6, 6])
    ];

    var animalCollection = [
        Object.create(Animal).init('Joro', 'dog', 4),
        Object.create(Animal).init('Gosho', 'dog', 4),
        Object.create(Animal).init('Sharo', 'dog', 4),
        Object.create(Animal).init('Mika', 'cat', 4),
        Object.create(Animal).init('BadAss', 'centipede', 100),
        Object.create(Animal).init('Koki', 'dog', 4),
        Object.create(Animal).init('Penka', 'chicken', 2),
        Object.create(Animal).init('Dinka', 'chicken', 2),
        Object.create(Animal).init('Kika', 'cat', 4),
        Object.create(Animal).init('Lola', 'cat', 4),
        Object.create(Animal).init('WhiteOne', 'wolf', 4)
    ];

    var booksCollection = [
        Object.create(Book).init('Book1', 'Author1'),
        Object.create(Book).init('Book2', 'Author1'),
        Object.create(Book).init('Book3', 'Author1'),
        Object.create(Book).init('Book4', 'Author2'),
        Object.create(Book).init('Book5', 'Author2'),
        Object.create(Book).init('Book6', 'Author3'),
        Object.create(Book).init('Book7', 'Author4'),
        Object.create(Book).init('Book8', 'Author5')
    ];

    // task 1 - filter by student's first and last name
    function firstBeforeLastName(collection) {
        var studentsCollectionByFirstLastName = _.chain(collection)
            .filter(function (student) {
                return student.fname < student.lname;
            })
            .sortBy(function (student) {
                return -student.fullName().length;
            }).value();

        return studentsCollectionByFirstLastName;
    }

    console.log('%c----Sorted Students By First/Last Name and printed Desc by full name----', 'background: #222; color: #bada55')
    console.log(firstBeforeLastName(students));

    // task 2 filtered by age between 18 and 24
    console.log('%c----Students that age is between 18 and 22 years----', 'background: #222; color: #bada55')
    function filterByAge(collection, min, max) {
        _.chain(students)
            .filter(function (student) {
                return ((min || 1) < student.age && student.age < (max || Number.MAX_VALUE));
            })
            .each(function (student) {
                console.log(student.fullName() + ' is ' + student.age);
            });
    }

    filterByAge(students, 18, 24);

    // task 3 Student with highest marks

    function getStudentWithHighestMark(collection) {
        return _.chain(collection)
            .max(function (item) {
                return item.averageScore();
            })
            .map(function (value, key) {
                return  key + ' : ' + value;
            })
            .value();
    }

    console.log('%c----Student with max grades----', 'background: #222; color: #bada55')
    console.log(getStudentWithHighestMark(students));


    // task 4 Group animals by species and sorts them by number of legs
    console.log('%c----Animals grouped by specie and sort by number of legs----', 'background: #222; color: #bada55')
    function groupAndSortAnimals(collection) {
        return _.chain(collection)
            .groupBy(function (item) {
                return item.specie;
            })
            .sortBy(function (item) {
                return item[0].numOfLegs;
            })
            .value();
    }

    console.log(groupAndSortAnimals(animalCollection));

    // task 5 Count all animals legs
    console.log('%c----Number of total animals legs count----', 'background: #222; color: #bada55')

    function countAllAnimalsLegs(collection) {
        var allCountedLegs = 0;

        _.each(collection, function (item) {
            allCountedLegs += item.numOfLegs;
        });

        return allCountedLegs;
    };

    console.log('Total number is: ' + countAllAnimalsLegs(animalCollection));

    // task 6 Find most popular author

    console.log('%c----Most popular author----', 'background: #222; color: #bada55')
    function mostCommonProperty(collection, prop) {
        return _.chain(collection)
            .groupBy(prop)
            .max(function (group) {
                return group.length;
            })
            .value()[0][prop];
    };

    console.log('Most popular is: ' + mostCommonProperty(booksCollection, 'author'));

    // task 7 Return peoples with most common first & last name
    console.log('%c----People with most common first and last name----', 'background: #222; color: #bada55')
    console.log('Most common first name is ' + mostCommonProperty(students, 'fname'));
    console.log('Most common last name is ' + mostCommonProperty(students, 'lname'));
};