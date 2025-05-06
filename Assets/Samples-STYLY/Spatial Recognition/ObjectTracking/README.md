# Object Tracking Sample

This project is a sample for Object Tracking in STYLY.

## Notes

This project does not include a pre-trained `referenceobject`.  
Please follow the steps below to prepare your own `referenceobject` and add it to the `ReferenceObjectLibrary`.

### Steps

1. **Prepare the object for training**  
   Prepare the object to be tracked and, if necessary, obtain 3D scans or image data.

2. **Perform training**  
   Refer to the following official documentation for instructions on generating a `referenceobject`:  
   [Implementing Object Tracking in Your visionOS App](https://developer.apple.com/documentation/visionOS/implementing-object-tracking-in-your-visionOS-app)

3. **Import the `referenceobject` into the project**  
   Add the `.referenceobject` file generated during training to the appropriate folder in this project.

4. **Register it in the `ReferenceObjectLibrary`**  
   Open `ReferenceObjectLibrary.asset` in the Unity Editor and add the imported `referenceobject` to the library.

5. **Upload to STYLY**  
   If necessary, upload the entire project to STYLY to utilize Object Tracking.

## File Structure

- `Object Tracking (Upload this prefab to STYLY).prefab`  
  A prefab to be uploaded to STYLY.

- `ReferenceObjectLibrary.asset`  
  A library that manages the objects to be tracked.
