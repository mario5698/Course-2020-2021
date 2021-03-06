import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:mock_and_sqlite/pages/Mock/bloc/todo_bloc.dart';
import 'package:mock_and_sqlite/pages/Mock/model/todo.dart';

class MockPage extends StatelessWidget {
  MockPage({Key key, this.title}) : super(key: key);

  final TodoBloc todoBloc = TodoBloc();
  final String title;

  final DismissDirection _dismissDirection = DismissDirection.horizontal;

  @override
  Widget build(BuildContext context) {
    SystemChrome.setSystemUIOverlayStyle(SystemUiOverlayStyle.dark.copyWith(
        statusBarColor: Colors.white,
        systemNavigationBarColor: Colors.white,
        systemNavigationBarIconBrightness: Brightness.dark,
        statusBarBrightness: Brightness.dark));
    return Scaffold(
      resizeToAvoidBottomPadding: false,
      body: SafeArea(
        child: Container(
          decoration: BoxDecoration(
            image: DecorationImage(
              image: AssetImage('assets/images/colorines.jpg'),
              fit: BoxFit.cover,
            ),
          ),
          padding: const EdgeInsets.only(left: 2.0, right: 2.0, bottom: 2.0),
          child: Container(
            child: getTodosWidget(),
          ),
        ),
      ),
      bottomNavigationBar: BottomAppBar(
        color: Colors.white,
        child: Container(
          decoration: BoxDecoration(
            image: DecorationImage(
              image: AssetImage('assets/images/fondo.jpg'),
              fit: BoxFit.cover,
            ),
            border: Border(
              top: BorderSide(color: Colors.blueGrey, width: 1.3),
            ),
          ),
          child: Row(
            mainAxisSize: MainAxisSize.max,
            children: <Widget>[
              IconButton(
                  icon: Icon(
                    Icons.menu,
                    color: Colors.indigoAccent,
                    size: 28,
                  ),
                  onPressed: () {
                    //just re-pull UI for testing purposes
                    todoBloc.getTodos();
                  }),
              Expanded(
                child: Text(
                  "Todo",
                  style: TextStyle(
                      color: Colors.white,
                      fontWeight: FontWeight.w600,
                      fontFamily: 'RobotoMono',
                      fontStyle: FontStyle.normal,
                      fontSize: 19),
                ),
              ),
              Wrap(children: <Widget>[
                IconButton(
                  icon: Icon(
                    Icons.search,
                    size: 28,
                    color: Colors.indigoAccent,
                  ),
                  onPressed: () {
                    _showTodoSearchSheet(context);
                  },
                ),
                Padding(
                  padding: EdgeInsets.only(right: 5),
                )
              ])
            ],
          ),
        ),
      ),
      floatingActionButtonLocation: FloatingActionButtonLocation.centerDocked,
      floatingActionButton: Padding(
        padding: EdgeInsets.only(bottom: 25),
        child: FloatingActionButton(
          elevation: 5.0,
          onPressed: () {
            _showAddTodoSheet(context);
          },
          backgroundColor: Colors.white,
          child: Icon(
            Icons.add,
            size: 32,
            color: Colors.indigoAccent,
          ),
        ),
      ),
    );
  }

  void _showAddTodoSheet(BuildContext context) {
    final _todoDescriptionFormController = TextEditingController();
    showModalBottomSheet(
      context: context,
      builder: (builder) {
        return new Padding(
          padding:
              EdgeInsets.only(bottom: MediaQuery.of(context).viewInsets.bottom),
          child: new Container(
            color: Colors.transparent,
            child: new Container(
              height: 135,
              decoration: new BoxDecoration(
                color: Colors.white,
                borderRadius: new BorderRadius.only(
                  topLeft: const Radius.circular(10.0),
                  topRight: const Radius.circular(10.0),
                ),
              ),
              child: Padding(
                padding: EdgeInsets.only(
                  left: 15,
                  right: 15,
                ),
                child: ListView(
                  children: <Widget>[
                    Row(
                      mainAxisSize: MainAxisSize.min,
                      crossAxisAlignment: CrossAxisAlignment.center,
                      children: <Widget>[
                        Expanded(
                          child: TextFormField(
                            controller: _todoDescriptionFormController,
                            textInputAction: TextInputAction.newline,
                            maxLines: 4,
                            style: TextStyle(
                                fontSize: 21, fontWeight: FontWeight.w400),
                            autofocus: true,
                            decoration: const InputDecoration(
                              hintText: 'I have to...',
                              labelText: 'New Todo',
                              labelStyle: TextStyle(
                                  color: Colors.indigoAccent,
                                  fontWeight: FontWeight.w500),
                            ),
                            validator: (String value) {
                              if (value.isEmpty) {
                                return 'Empty description!';
                              }
                              return value.contains('')
                                  ? 'Do not use the @ char.'
                                  : null;
                            },
                          ),
                        ),
                        Padding(
                          padding: EdgeInsets.only(left: 5, top: 15),
                          child: CircleAvatar(
                            backgroundColor: Colors.indigoAccent,
                            radius: 18,
                            child: IconButton(
                              icon: Icon(
                                Icons.save,
                                size: 22,
                                color: Colors.white,
                              ),
                              onPressed: () {
                                final newTodo = Todo(
                                    description: _todoDescriptionFormController
                                        .value.text);
                                if (newTodo.description.isNotEmpty) {
                                  todoBloc.addTodo(newTodo);
                                  Navigator.pop(context);
                                }
                              },
                            ),
                          ),
                        )
                      ],
                    ),
                  ],
                ),
              ),
            ),
          ),
        );
      },
    );
  }

  void _showTodoSearchSheet(BuildContext context) {
    final _todoSearchDescriptionFormController = TextEditingController();
    showModalBottomSheet(
      context: context,
      builder: (builder) {
        return new Padding(
          padding:
              EdgeInsets.only(bottom: MediaQuery.of(context).viewInsets.bottom),
          child: new Container(
            color: Colors.transparent,
            child: new Container(
              height: 135,
              decoration: new BoxDecoration(
                  color: Colors.white,
                  borderRadius: new BorderRadius.only(
                      topLeft: const Radius.circular(10.0),
                      topRight: const Radius.circular(10.0))),
              child: Padding(
                padding: EdgeInsets.only(
                  left: 15,
                  right: 15,
                ),
                child: ListView(
                  children: <Widget>[
                    Row(
                      mainAxisSize: MainAxisSize.min,
                      crossAxisAlignment: CrossAxisAlignment.center,
                      children: <Widget>[
                        Expanded(
                          child: TextFormField(
                            controller: _todoSearchDescriptionFormController,
                            textInputAction: TextInputAction.newline,
                            maxLines: 4,
                            style: TextStyle(
                                fontSize: 18, fontWeight: FontWeight.w400),
                            autofocus: true,
                            decoration: const InputDecoration(
                              hintText: 'Search for todo...',
                              labelText: 'Search *',
                              labelStyle: TextStyle(
                                  color: Colors.indigoAccent,
                                  fontWeight: FontWeight.w500),
                            ),
                            validator: (String value) {
                              return value.contains('@')
                                  ? 'Do not use the @ char.'
                                  : null;
                            },
                          ),
                        ),
                        Padding(
                          padding: EdgeInsets.only(left: 5, top: 15),
                          child: CircleAvatar(
                            backgroundColor: Colors.indigoAccent,
                            radius: 18,
                            child: IconButton(
                              icon: Icon(
                                Icons.search,
                                size: 22,
                                color: Colors.white,
                              ),
                              onPressed: () {
                                todoBloc.getTodos(
                                    query: _todoSearchDescriptionFormController
                                        .value.text);
                                //dismisses the bottomsheet
                                Navigator.pop(context);
                              },
                            ),
                          ),
                        )
                      ],
                    ),
                  ],
                ),
              ),
            ),
          ),
        );
      },
    );
  }

  Widget getTodosWidget() {
    return StreamBuilder(
      stream: todoBloc.todos,
      builder: (BuildContext context, AsyncSnapshot<List<Todo>> snapshot) {
        return getTodoCardWidget(snapshot);
      },
    );
  }

  Widget getTodoCardWidget(AsyncSnapshot<List<Todo>> snapshot) {
    if (snapshot.hasData) {
      return snapshot.data.length != 0
          ? ListView.builder(
              itemCount: snapshot.data.length,
              itemBuilder: (context, itemPosition) {
                Todo todo = snapshot.data[itemPosition];
                final Widget dismissibleCard = new Dismissible(
                  background: Container(
                    child: Padding(
                      padding: EdgeInsets.only(left: 10),
                      child: Align(
                        alignment: Alignment.centerLeft,
                        child: Row(
                          children: [
                            Icon(
                              Icons.delete,
                              color: Colors.black,
                              size: 30,
                            ),
                            Text(
                              "Borrar",
                              style:
                                  TextStyle(color: Colors.white, fontSize: 20),
                            ),
                          ],
                        ),
                      ),
                    ),
                    color: Colors.redAccent,
                  ),
                  onDismissed: (direction) {
                    todoBloc.deleteTodoById(todo.id);
                  },
                  direction: _dismissDirection,
                  key: new ObjectKey(todo),
                  child: Card(
                    shape: RoundedRectangleBorder(
                      side: BorderSide(color: Colors.red, width: 0.5),
                      borderRadius: BorderRadius.circular(5),
                    ),
                    color: Colors.white12,
                    child: ListTile(
                      leading: InkWell(
                        onTap: () {
                          todo.isDone = !todo.isDone;
                          todoBloc.updateTodo(todo);
                        },
                        //check
                        child: Container(
                          child: Padding(
                            padding: const EdgeInsets.all(15.0),
                            child: todo.isDone
                                ? Icon(
                                    Icons.done,
                                    size: 26.0,
                                    color: Colors.indigoAccent,
                                  )
                                : Icon(
                                    Icons.check_box_outline_blank,
                                    size: 26.0,
                                    color: Colors.tealAccent,
                                  ),
                          ),
                        ),
                      ),
                      title: Text(
                        todo.description,
                        style: TextStyle(
                            fontSize: 16.5,
                            fontFamily: 'RobotoMono',
                            fontWeight: FontWeight.w500,
                            decoration: todo.isDone
                                ? TextDecoration.lineThrough
                                : TextDecoration.none),
                      ),
                    ),
                  ),
                );
                return dismissibleCard;
              },
            )
          : Container(
              child: Center(
              //this is used whenever there 0 Todo
              //in the data base
              child: noTodoMessageWidget(),
            ));
    } else {
      return Center(
        child: loadingData(),
      );
    }
  }

  Widget loadingData() {
    //pull todos again
    todoBloc.getTodos();
    return Container(
      child: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            CircularProgressIndicator(),
            Text("Cargando...",
                style: TextStyle(fontSize: 19, fontWeight: FontWeight.w500))
          ],
        ),
      ),
    );
  }

  Widget noTodoMessageWidget() {
    return Container(
      child: Text(
        "Empiece a agregar cosas...",
        style: TextStyle(fontSize: 19, fontWeight: FontWeight.w500),
      ),
    );
  }

  dispose() {
    todoBloc.dispose();
  }
}
