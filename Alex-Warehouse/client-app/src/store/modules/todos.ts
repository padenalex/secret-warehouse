import axios from 'axios';

const state = {
    todos: []
};

const getters = {
    allTodos: (state: { todos: Array<any>; }) => state.todos
};

const actions = {
    async fetchTodos({ commit }: {commit: Function}) {
        const response = await axios.get(
            '/api/todo'
        );

        commit('setTodos', response.data);
    },
    
    async updateTodo({ commit }: {commit: Function}, updTodo: { id: any; }) {
        const response = await axios.put(
            `/api/todo/${updTodo.id}`,
            updTodo
        );

        console.log(response.data);

        commit('updateTodo', response.data);
    }
};

const mutations = {
    setTodos: (state: { todos: Array<any>; }, todos: Array<any>) => (state.todos = todos),
    updateTodo: (state: { todos: Array<any>; }, updTodo: any) => {
        const index = state.todos.findIndex(todo => todo.id === updTodo.id);
        if (index !== -1) {
            state.todos.splice(index, 1, updTodo);
        }
    }
};

export default {
    state,
    getters,
    actions,
    mutations
};
