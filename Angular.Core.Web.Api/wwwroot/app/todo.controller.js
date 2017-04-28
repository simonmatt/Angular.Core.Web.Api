(function () {
    'use strict';

    angular
        .module('app')
        .controller('TodoController', TodoController);

    TodoController.$inject = ['TodoService'];

    function TodoController(TodoService) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'My Simple Todo';
        vm.todo = {};
        vm.todos = [];

        vm.addTodo = addTodo;

        function addTodo(evt) {
            
            var todo = {
                title: vm.todo.title
            }

            TodoService.addTodo(todo).then(function () {
                TodoService.getTodos().then(function (response) {
                    vm.todos = response.data;
                    vm.todo.title = '';
                });
            });

            
        }

        activate();

        function activate() {
            TodoService.getTodos().then(function (response) {
                vm.todos = response.data;
            });
        }
    }
})();