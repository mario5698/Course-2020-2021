import 'package:flutter/material.dart';
import 'package:flutter/cupertino.dart';

class SignupPage extends StatefulWidget {
  @override
  _SignupPageState createState() => _SignupPageState();
}

class _SignupPageState extends State<SignupPage>
    with SingleTickerProviderStateMixin {
  Color _color1 = Color.fromRGBO(166, 67, 70, 1);
  Color _color2 = Colors.white;
  String _gender = 'male';

  AnimationController controller;
  Animation topAnimation1,
      topAnimation2,
      topAnimation3,
      bottomAnimation1,
      bottomAnimation2,
      bottomAnimation3,
      sideAnimation1,
      sideAnimation2;

  @override
  void initState() {
    controller = AnimationController(
      vsync: this,
      duration: Duration(seconds: 2),
    );
    topAnimation1 = Tween(begin: -1.0, end: 0.0).animate(CurvedAnimation(
        parent: controller,
        curve: Interval(.5, 1.0, curve: Curves.fastOutSlowIn)));

    topAnimation2 = Tween(begin: -1.0, end: 0.0).animate(CurvedAnimation(
        parent: controller,
        curve: Interval(.7, 1.0, curve: Curves.fastOutSlowIn)));

    topAnimation3 = Tween(begin: -1.0, end: 0).animate(CurvedAnimation(
        parent: controller,
        curve: Interval(.9, 1.0, curve: Curves.fastOutSlowIn)));

    bottomAnimation1 = Tween(begin: 1.0, end: 0.0).animate(CurvedAnimation(
        parent: controller,
        curve: Interval(.5, 1.0, curve: Curves.fastOutSlowIn)));

    bottomAnimation2 = Tween(begin: 1.0, end: 0.0).animate(CurvedAnimation(
        parent: controller,
        curve: Interval(.7, 1.0, curve: Curves.fastOutSlowIn)));

    bottomAnimation3 = Tween(begin: 1.0, end: 0).animate(CurvedAnimation(
        parent: controller,
        curve: Interval(.9, 1.0, curve: Curves.fastOutSlowIn)));

    sideAnimation1 = Tween(begin: -1.0, end: 0.0).animate(CurvedAnimation(
        parent: controller,
        curve: Curves.bounceInOut));

    sideAnimation2 = Tween(begin: 1.0, end: 0).animate(CurvedAnimation(
        parent: controller,
        curve: Curves.bounceInOut));
  }

  @override
  Widget build(BuildContext context) {
    final double _height = MediaQuery.of(context).size.height;
    final double _width = MediaQuery.of(context).size.width;
    controller.forward();
    return AnimatedBuilder(
        animation: controller,
        builder: (BuildContext context, Widget child) {
          return Scaffold(
            appBar: AppBar(
              backgroundColor: Colors.orange[400],
              title: Text(
                'Reg??strate',
                style: TextStyle(fontFamily: 'Quicksand'),
              ),
              centerTitle: true,
              elevation: 0,
            ),
            body: ListView(
              shrinkWrap: true,
              children: <Widget>[
                SizedBox(height: 20),
                Transform(
                    transform: Matrix4.translationValues(
                        0, topAnimation3.value * _height, 0)),
                SizedBox(height: 20),
                Transform(
                    transform: Matrix4.translationValues(
                        0, topAnimation2.value * _height, 0),
                    child: buildNameColumn()),
                SizedBox(height: 20),
                Transform(
                  transform: Matrix4.translationValues(
                      0, topAnimation1.value * _height, 0),
                  child: buildGenderText(),
                ),
                SizedBox(height: 20),
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  children: <Widget>[
                    Transform(
                      transform: Matrix4.translationValues(
                          sideAnimation1.value * _width, 0,0),
                      child: GestureDetector(
                        onTap: () {
                          setState(() {
                            if (_gender == 'male')
                              _gender = 'female';
                            else
                              _gender = 'male';

                            _gender == 'male'
                                ? _color1 = Color.fromRGBO(166, 67, 70, 1)
                                : _color1 = Colors.white;
                            _gender == 'male'
                                ? _color2 = Colors.white
                                : _color2 = Color.fromRGBO(166, 67, 70, 1);
                          });
                        },
                        child: genderBox(
                            context, _color1, 'Hombre', 'assets/pics/male.png'),
                      ),
                    ),
                    Transform(
                      transform: Matrix4.translationValues(
                          sideAnimation2.value * _width, 0, 0),
                      child: GestureDetector(
                          onTap: () {
                            setState(() {
                              if (_gender == 'male')
                                _gender = 'female';
                              else
                                _gender = 'male';

                              _gender == 'male'
                                  ? _color1 = Color.fromRGBO(166, 67, 70, 1)
                                  : _color1 = Colors.white;
                              _gender == 'male'
                                  ? _color2 = Colors.white
                                  : _color2 = Color.fromRGBO(166, 67, 70, 1);
                            });
                          },
                          child: genderBox(context, _color2, 'Mujer',
                              'assets/pics/female.png')),
                    ),
                  ],
                ),
                SizedBox(height: 20),
                Transform(
                    transform: Matrix4.translationValues(
                        0, bottomAnimation1.value * _height, 0),
                    child: buildBorninText()),
                Transform(
                    transform: Matrix4.translationValues(
                        0, bottomAnimation2.value * _height, 0),
                    child: buildPickerContainer()),
                SizedBox(height: 20),
                Transform(
                    transform: Matrix4.translationValues(
                        0, bottomAnimation3.value * _height, 0),
                    child: buildNextButton())
              ],
            ),
          );
        });
  }

  Padding buildNextButton() {
    return Padding(
      padding: EdgeInsets.only(left: 80, right: 80),
      child: MaterialButton(
        shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(30)),
        onPressed: () {},
        child: Text('SIGUIENTE', style: TextStyle(color: Colors.white),),
        color: Color.fromRGBO(166, 67, 70, 1),
      ),
    );
  }

  Container buildPickerContainer() {
    return Container(
      margin: EdgeInsets.only(left: 20, right: 20),
      height: 180,
      child: CupertinoDatePicker(
        mode: CupertinoDatePickerMode.date,
        onDateTimeChanged: (_) {},
        initialDateTime: DateTime(2019),
        maximumDate: DateTime(2030),
        minimumDate: DateTime(2000),
      ),
    );
  }

  Padding buildBorninText() {
    return Padding(
      padding: EdgeInsets.only(left: 20),
      child: Text(
        'Fecha de nacimiento',
        style: TextStyle(
          color: Colors.black,
          fontSize: 22,
          fontFamily: 'Quicksand',
          fontWeight: FontWeight.bold,
        ),
      ),
    );
  }

  Padding buildGenderText() {
    return Padding(
      padding: EdgeInsets.only(left: 20),
      child: Text(
        'G??nero',
        style: TextStyle(
          color: Colors.black,
          fontSize: 22,
          fontFamily: 'Quicksand',
          fontWeight: FontWeight.bold,
        ),
      ),
    );
  }

  Column buildNameColumn() {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        Padding(
          padding: EdgeInsets.only(left: 20),
          child: Text(
            'Nombre y Apellidos',
            style: TextStyle(
              color: Colors.black,
              fontSize: 22,
              fontFamily: 'Quicksand',
              fontWeight: FontWeight.bold,
            ),
          ),
        ),
        Padding(
          padding: EdgeInsets.only(left: 20, right: 20),
          child: TextField(),
        ),
      ],
    );
  }


  Widget genderBox(BuildContext context, Color color, String text, String img) {
    return Container(
      height: 100,
      width: MediaQuery.of(context).size.width * 0.42,
      decoration: BoxDecoration(
          color: color,
          borderRadius: BorderRadius.circular(8),
          boxShadow: <BoxShadow>[
            BoxShadow(
              color: Colors.grey,
              blurRadius: 10,
            )
          ]),
      child: Column(
        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
        crossAxisAlignment: CrossAxisAlignment.center,
        children: <Widget>[
          Image.asset(
            img,
            width: 70,
            height: 70,
          ),
          Text(
            text,
            style: TextStyle(
              fontSize: 16,
              color: color == Color.fromRGBO(166, 67, 70, 1) ? Colors.white : Colors.black,
            ),
          ),
        ],
      ),
    );
  }
}
