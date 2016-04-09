function [ output_args ] = ObjectF( dist_C2C, path)
%OBJECTF Summary of this function goes here
%   Detailed explanation goes here

path = [path ; path(1,:)];  % new matrix, first row = last row(return to start)

% compute the object, sum of distance c2c
object = 0;
for i = 1 : size(path,1)-1
    object = object + dist_C2C(path(i),path(i+1));
end
output_args = object;

end

