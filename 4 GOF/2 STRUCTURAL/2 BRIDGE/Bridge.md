## BRIDGE PATTERN:
Bridge is a Conceptual design pattern that divides business logic or huge class into separate class hierarchies that can be developed independently.

One of these hierarchies (often called the Abstraction) will get a reference to an object of the second hierarchy (Implementation). The abstraction will be able to delegate some (sometimes, most) of its calls to the implementations object. Since all implementations will have a common interface, they’d be interchangeable inside the abstraction.



## STRUCTURE:

ABSTRACTION

EXTENDED ABSTRACTION: ABSTRACTION

IIMPLEMENTATION:

CONCRETE IMPLEMENTATIONA: IIMPLEMENTATION

CONCRETE IMPLEMENTATIONB: IIMPLEMENTATION

CLIENT

Bridge pattern: divide businss logic into separate classes that can develop independently
