import axios from 'axios';

const state = {
    todos: [],
    todo: ''
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
    
    async newTodo({ commit }: {commit: Function}, todo: { title:any; description:any; completed:any;}) {
        const response = await axios.post('/api/todo', todo);
      //  console.log(response.data);
        commit('addTodo', response.data)
    },
    
    async updateTodo({ commit }: {commit: Function}, updTodo: { id: any; }) {
        const response = await axios.put(
            `/api/todo/${updTodo.id}`,
            updTodo
        );
        //console.log(response.data);
        commit('updateTodo', response.data);
    }
};

const mutations = {
    setTodos: (state: { todos: Array<any>; }, todos: Array<any>) => (state.todos = todos),
    addTodo: (state: { todos: Array<any>; }, todo: any) => (state.todos.unshift(todo)),
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
