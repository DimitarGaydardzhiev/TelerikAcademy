function solve() {

    function validateTitle(title) {
        if (title === null || typeof title !== 'string') {
            throw new Error;
        }
        
        if (title.indexOf(' ') === 0 || title.lastIndexOf(' ') === title.length - 1) {
            throw new Error;
        }
        
        if (title.indexOf('  ') > -1) {
            throw new Error;
        }

        if (title.length < 1) {
            throw new Error;
        }
    }

    function validatePresentation(presentations) {
        if (!presentations || presentations.length === 0) {
            throw new Error('Presentations should not be empty array!');
        }

        presentations.forEach(function (title) {
            validateTitle(title);
        });
    }

    function validateCourse(title, presentations) {
        validateTitle(title);
        validatePresentation(presentations);
    }

    function validateIDs(object, studentID, homeworkID) {
        if (studentID > object.students.length || studentID < 1) {
            throw new Error;
        }

        if (homeworkID > object.presentations.length || homeworkID < 1) {
            throw new Error;
        }
    }

    function validateStudent(name) {
        var studentNames;

        if (!name) {
            throw new Error;
        }

        studentNames = name.split(' ');

        if (studentNames.length !== 2) {
            throw new Error;
        }

        studentNames.forEach(function (val) {
            var restOfName;

            if (val[0] !== val[0].toUpperCase()) {
                throw new Error;
            }

            restOfName = val.slice(1);

            if (restOfName.toLowerCase() !== restOfName) {
                throw new Error;
            }
        });
    }

    function Student(name) {
        var nameParts;

        validateStudent(name);

        nameParts = name.split(' ');
        
        this.firstname = nameParts[0];
        this.lastname = nameParts[1];
        this.id = 0;
        this.finalScore = 0;

        return Student;
    };

    var Course = {
        init: function (title, presentations) {
            var that = this;

            validateCourse(title, presentations);

            that.title = title || '';
            that.presentations = presentations || '';
            that.students = [];

            return that;

        },

        addStudent: function (name) {

            validateStudent(name);
            var newStudent = new Student(name);

            this.students.push(newStudent);
            var id = this.students.length + 1;
            return id;
        },

        getAllStudents: function () {
            return this.students;
        },

        submitHomework: function (studentID, homeworkID) {
            validateIDs(this, studentID, homeworkID);
        },

        pushExamResults: function (results) {
            var that = this;

            results.forEach(function (result) {
                var student = that.getStudentById(result.studentID);
            })
        },

        getStudentById: function (id) {
            var student = this.students.filter(function (id) {
                return student.id === id;
            })

            return student[0];
        },

        getTopStudents: function () {
            var that = this,
                sortedStudents = [];

            sortedStudents = this.students.sort(function (a, b) {
                return a.finalScore - b.finalScore;
            })

            return sortedStudents.slice(0, 10);
        },

        calculateFinalScore: function (student) {
            var finalResult,
                examResult = student.examResult * 0.75,
                homeworkResult = (student.homeworkCompleted / this.homeworks.length) * 0.25;

            student.finalScore = examResult + homeworkResult;
        },

    };
    return Course;
}


module.exports = solve;