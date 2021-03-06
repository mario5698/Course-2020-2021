import 'dart:async';

class Dog {
  final String name;
  final String location;
  final String description;
  String imageUrl;

  int rating = 10;

  Dog(this.name, this.location, this.description, this.imageUrl);

  Future getImageUrl() async {
    if (imageUrl != null) {
      return;
    }
  }
}
