(function () {
    'use strict';
    angular.module('app')
        .controller('TodoController', TodoController);

    TodoController.$inject = ['TodoService'];

    function TodoController(TodoService) {
        var vm = this;
        vm.title = 'my simple todo';
        vm.todo = {};
        vm.todos = [];

        vm.addTodo = addTodo;

        function addTodo() {
            var todo = {
                title: vm.todo.title
            };

            TodoService.addTodo(todo).then(function () {
                TodoService.getTodos().success(function (response) {
                    vm.todos = response;
                });
            });
        }

        activate();

        function activate() {
            TodoService.getTodos().success(function (response) {
                vm.todos = response;
            });
        }
    }
})();